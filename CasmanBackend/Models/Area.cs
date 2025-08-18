using System.ComponentModel.DataAnnotations;

namespace CasmanSln.Models
{
    public class Area
    {

        [Key]
        public string AreaDesc { get; set; }
        public string CountryCode { get; set; }
        public string CountryUnit { get; set; }
        public string CountryGroup { get; set; }
        public string CountryTax { get; set; }
        public string CtryNominalCode { get; set; }
        public int SortColumn { get; set; }
        public string AreaJurisdiction { get; set; }

        public int? AdultLimitationMonths { get; set; }
        public int? ChildrenLimitationMonths { get; set; }
        public int? BrainDamageLimitationMonths { get; set; }

        public bool Valid { get; set; }
    }

}
