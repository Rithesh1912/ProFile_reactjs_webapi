using System.ComponentModel.DataAnnotations;

namespace CasmanSln.Models
{
    public class Specialty
    {
        [Key]
        public string SpcltyCode { get; set; }   
        public string SpcltyDesc { get; set; }   
        public char ClaimsUse { get; set; }      
        public char MemUse { get; set; }         
    }

}
