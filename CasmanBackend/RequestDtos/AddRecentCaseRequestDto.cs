namespace CasmanSln.RequestDtos

{

    public class AddRecentCaseRequestDto

    {

        public string staff_Id { get; set; }

        public string case_Id { get; set; }

        public string subsid_Id { get; set; }

        public DateTime search_date = DateTime.Now;

    }

}

