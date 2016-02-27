using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPp.Models
{
    public class Course
    {
        public int CourseId { get; set; } 
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<Student> StudentList { get; set; }
        public Department ADepartment { get; set; } 
    }
}