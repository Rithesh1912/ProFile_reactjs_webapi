using System.ComponentModel.DataAnnotations;

namespace CasmanSln.Models
{
    public class CasePractice
    {
        [Key]
        public int prac_area_code {  get; set; }
        public string prac_area_desc { get; set; }

        public char valid { get; set; }


    }
}
