using System.ComponentModel.DataAnnotations;

namespace CasmanSln.Models
{
    public class RecentCases
    {
        [Key]
        public string staffId {  get; set; }
        public string caseId { get; set;}
        public string subsidId {  get; set;}
        public DateTime searchDate=DateTime.Now;
    }
}
