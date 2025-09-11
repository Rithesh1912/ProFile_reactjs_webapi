using System.ComponentModel.DataAnnotations;

namespace CasmanSln.Models
{
    public class Status
    {
            [Key]
            public string case_stat { get; set; }
            public string stat_desc { get; set; }
            public char valid { get; set; }
        
    }
}

