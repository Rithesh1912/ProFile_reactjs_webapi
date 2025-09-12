
﻿using System.ComponentModel.DataAnnotations;

namespace CasmanSln.Models
{
    public class Department
    {
        [Key]
        public string DeptId {  get; set; }
        public string DeptName {  get; set; }
        public string valid { get; set; }
        public string depatAdAccount { get; set; }

    }
}
