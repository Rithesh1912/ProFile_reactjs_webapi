using CasmanSln.Models;

namespace CasmanSln.ResponseDtos
{
    public class PagedResult<CaseSearchResponseDto>
    {
        public List<CaseSearchResponseDto> Items { get; set; } = new List<CaseSearchResponseDto>();
        public int TotalCount { get; set; }      // total records in DB
        public int PageNumber { get; set; }      // current page
        public int PageSize { get; set; }        // size per page
        public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
    }
}
