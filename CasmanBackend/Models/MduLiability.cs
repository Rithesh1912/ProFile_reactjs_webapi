using System.ComponentModel.DataAnnotations;

namespace CasmanSln.Models
{
    public class MduLiability
    {
        [Key]
        public string case_type { get; set; }
        public int mdu_liability { get; set; }

        public string liab_desc { get; set; }
        public char valid { get; set; } 
    }
}
