namespace CasmanSln.Dtos
{
    public class CreateCaseRequestDto
    {
        public string PracNum { get; set; }
        public string PracRole { get; set; }
        public string MduUnit { get; set; }
        public string PracLastName { get; set; }
        public string PracFirstName { get; set; }
        public string PracInit { get; set; }
        public string PracSex { get; set; }
        public string PracDefOrg { get; set; }
        public string PracTow { get; set; }
        public short? PracSource { get; set; }
        public string UserId { get; set; }
        public string CaseCreateSource { get; set; } = "Casman";
    }
}
