namespace CasmanSln.ResponseDtos
{
    public class GetRecentCaseResponseDto
    {
        public string case_id { get; set;}
        public string subsid_id {  get; set;}
        public string scrt_user {  get; set;}
        public string second_scrt_user { get; set;}
        public string? status = "Active";
    }
}
