using System.ComponentModel.DataAnnotations;

namespace CasmanSln.Models
{
    public class adv_team
    {
        [Key]
        public int TeamId {  get; set; }
        public string TeamName {  get; set; }

        public string Dept_Id {  get; set; }
    }
}
