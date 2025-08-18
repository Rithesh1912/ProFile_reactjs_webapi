using System.ComponentModel.DataAnnotations;

namespace CasmanSln.Models
{
    public class Specialty
    {
        [Key]
        public string SpcltyCode { get; set; }   
        public string SpcltyDesc { get; set; }   
        public bool ClaimsUse { get; set; }      
        public bool MemUse { get; set; }         
    }

}
