using CasmanSln.DataAccess.Interface;
using CasmanSln.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System;

namespace CasmanSln.DataAccess.Repository
{
    public class PractionerDetails : IPractionerDetails
    {
        private readonly CasmanDbContext _context;

        public PractionerDetails(CasmanDbContext context)
        {
            _context = context;
        }
        public async Task<List<CasePractioner>> GetAllPractionerDetails()
        {
            var practionerdetails = await _context.t_case_prac.ToListAsync();
            return practionerdetails;
        }

        public async Task<CasePractioner> GetPractionerByCaseId(string caseId, string subId)
        {
            string FullCaseId = caseId + "-" + subId;
            var practionerdetail = await _context.t_case_prac.FirstOrDefaultAsync(c => c.CaseId == caseId && c.SubsidId == subId);
            return practionerdetail;
        }

        public async Task<CasePractioner> CreatePractioner(CasePractioner newPrac)
        {
            var currentYear = DateTime.Now.Year % 100; // 25 for 2025
            string yearPrefix = currentYear.ToString("D2"); // "25"

            // Find the last CaseId for this year (string comparison)
            var lastCase = await _context.t_case
                .Where(c => c.CaseId.StartsWith(yearPrefix))
                .OrderByDescending(c => c.CaseId)
                .FirstOrDefaultAsync();

            int sequence = 1;
            if (lastCase != null)
            {
                // Take the numeric part after the year and increment
                sequence = int.Parse(lastCase.CaseId.Substring(2)) + 1;
            }

            // Build CaseId in format YY00001
            string CaseId = $"{yearPrefix}{sequence:D5}";
            string SubId = "00";
            var newPractioner = new CasePractioner()
            {
                CaseId = CaseId,
                SubsidId = SubId,
                PracFirstName = newPrac.PracFirstName,
                PracLastName = newPrac.PracLastName,
                PracSex = newPrac.PracSex,
                PracNum = newPrac.PracNum,
                PracRole = "Lead",
                CharmPolicyNumber = "POLICY-001"
            };
            _context.t_case_prac.Add(newPractioner);
            await _context.SaveChangesAsync();


            return newPractioner;

        }

        public async Task<bool>UpdatePractionerDetails(string PracNum, CasePractioner UpdatedcasePractioner)
        {
            var prac = await _context.t_case_prac.FirstOrDefaultAsync(x=>x.PracNum == PracNum);
            if (prac == null)
            {
                return false;
            }
            prac.PracFirstName= UpdatedcasePractioner.PracFirstName;
            prac.PracLastName= UpdatedcasePractioner.PracLastName;
            prac.PracSex=UpdatedcasePractioner.PracSex;
            prac.PracRole=UpdatedcasePractioner.PracRole;

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeletePractioner(string pracNum)
        {
            var prac = await _context.t_case_prac
                .FirstOrDefaultAsync(x => x.PracNum == pracNum);

            if (prac == null)
                return false;

            _context.t_case_prac.Remove(prac);
            await _context.SaveChangesAsync();

            return true;
        }
    }

    }
