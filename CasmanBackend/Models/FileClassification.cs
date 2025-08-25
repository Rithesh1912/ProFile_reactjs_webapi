using System.ComponentModel.DataAnnotations;

namespace CasmanSln.Models
{
    public class FileClassification
    {
        [Key]
        public int file_class_code { get; set; }
        public string class_desc { get; set; }
        public char valid { get; set; }

    }
}
