using CasmanSln.Models;

namespace CasmanSln.ResponseDtos
{
    public class DropdownResponseDto
    {
        public List<string> Specialties { get; set; } = new();
        public List<string> Liabilities { get; set; } = new();
        public List<string> CaseTypes { get; set; } = new();
        public List<string> Statuses { get; set; } = new();
        public List<string> Departments { get; set; } = new();
        public List<string> Categories { get; set; } = new();
        public List<string> Practices { get; set; } = new();
        public List<string> Classifications { get; set; } = new();
        public List<string> Staff { get; set; } = new();
        public List<string> Countries { get; set; } = new();
        public List<string> Indemnifiers { get; set; } = new();
    }
}
