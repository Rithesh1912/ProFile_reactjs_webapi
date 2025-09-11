using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CasmanSln.Models
{
    public class Indemnifier
    {
        [Key]
        public string Def_Org { get; set; }

        public string Def_Org_Name { get; set; }

        public int Def_Order { get; set; }

        public char Valid { get; set; }
    }
}
