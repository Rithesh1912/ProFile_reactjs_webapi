using System.ComponentModel.DataAnnotations;

namespace CasmanSln.Models
{
    public class PracArea
    {
        [Key]
        public int prac_area_code {  get; set; }
        public string prac_area_desc {  get; set; }

        public bool valid {  get; set; }
    }
}
