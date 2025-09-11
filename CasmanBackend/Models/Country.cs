using System.ComponentModel.DataAnnotations;

namespace CasmanSln.Models
{
    public class Country
    {
        [Key]
        public string CountryCode { get; set; }        
        public string Currency { get; set; }           
        public string Description { get; set; }        
        public string CountryNominalCode { get; set; } 
        public bool Valid { get; set; }              
    }

}
