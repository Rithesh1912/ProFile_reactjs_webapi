namespace CasmanSln.RequestDtos
{
    public class CaseSearchRequestDto
    {
        public string CaseID { get; set; }   
        public string SubsidID { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        

    }
}
