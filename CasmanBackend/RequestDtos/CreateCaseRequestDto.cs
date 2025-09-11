using Microsoft.AspNetCore.Antiforgery;
using System.ComponentModel.DataAnnotations;

namespace CasmanSln.Dtos
{
    public class CreateCaseRequestDto
    {
        public string? PracNum { get; set; }
        [Required]
        public string PracRole { get; set; }
        public string? MduUnit { get; set; }
        [Required]
        public string PracLastName { get; set; }
        public string? PracFirstName { get; set; }
        public string? PracInit { get; set; }
        public string? PracSex { get; set; }
        [Required]
        public string PracDefOrg { get; set; }
        [Required]
        public string PracTow { get; set; }
        
        public string? UserId { get; set; }
        public string? CaseCreateSource { get; set; } = "Casman";
    }
}
