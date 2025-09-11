using System.ComponentModel.DataAnnotations;

namespace CasmanSln.Models
{
    public class Staff
    {
        [Key]
        public string StaffNo { get; set; }        
        public string StaffId { get; set; }      
        public string StaffName { get; set; }
        public string DeptId { get; set; }
        public string Team { get; set; }
        public int TeamId { get; set; }
        public string ModifiedBy { get; set; }   
        public string PasswordHash {  get; set; }
    }

}
