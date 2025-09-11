using System.ComponentModel.DataAnnotations;

namespace CasmanSln.Models
{
    public class Category
    {
        [Key]
        public int Category_no { get; set; }

        public string Description { get; set; }

        public int cat_nominal_code { get; set; }

        public char valid {  get; set; }
    }
}
