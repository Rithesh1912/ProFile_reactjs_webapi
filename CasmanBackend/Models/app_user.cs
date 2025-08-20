using System.ComponentModel.DataAnnotations;

namespace CasmanSln.Models
{
    public class app_user
    {
        [Key]
        public string userId {  get; set; }
        public string appId {  get; set; }

        public string role {  get; set; }
        public string? level {  get; set; }
    }
}
