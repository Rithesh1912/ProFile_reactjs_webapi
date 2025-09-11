using System.ComponentModel.DataAnnotations;

namespace CasmanSln.Models
{
    public class CaseType
    {
        [Key]
        public string case_type { get; set; }
        public string type_desc { get; set; }
        public char valid { get; set; }
    }
}
