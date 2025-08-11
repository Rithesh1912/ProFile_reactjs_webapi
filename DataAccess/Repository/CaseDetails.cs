using CasmanSln.DataAccess.Interface;
using CasmanSln.Models;
using Microsoft.EntityFrameworkCore;

namespace CasmanSln.DataAccess.Repository
{
    public class CaseDetails : ICaseDetails
    {
        private readonly CasmanDbContext _context;

        public CaseDetails(CasmanDbContext context)
        {
            _context = context;
        }

        public async Task<List<Case>> GetAllCaseDetails()
        {
            var casedetails = await _context.t_case.ToListAsync();
            return casedetails;
            
        }

        public async Task<Case> GetCaseDetailsById(string caseId,string subId)
        {
            string FullCaseId = caseId+"-"+subId;
            var casedetail = await _context.t_case.FirstOrDefaultAsync(c => c.CaseId == caseId && c.SubsidId == subId);
            return casedetail;
        }

        public async Task<Case> CreateCase(Case newCase)
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
            var caseEntity = new Case
            {
                CaseId = CaseId,
                SubsidId = SubId,
                MduUnit = newCase.MduUnit,
                CaseType = newCase.CaseType,
                CaseStat = newCase.CaseStat,
                ScrtUsr = newCase.ScrtUsr,
                Offc = newCase.Offc,
                CaseCat = newCase.CaseCat,
                CaseClass = newCase.CaseClass,
                SpcltyMajCode = newCase.SpcltyMajCode,
                SpcltyMinCode = newCase.SpcltyMinCode,
                HptlLoc = newCase.HptlLoc,
                HaFpcName = newCase.HaFpcName,
                AreaCode = newCase.AreaCode,
                PracAreaCode = newCase.PracAreaCode,
                IncdtDate = newCase.IncdtDate,
                OpenDate = newCase.OpenDate,
                CloseDate = newCase.CloseDate
             
            };

          

            _context.t_case.Add(caseEntity);
            await _context.SaveChangesAsync();

            return caseEntity;
        }

        /*public Task<Case>UpdateCase(Case case)
        {

        }*/




    }
}
