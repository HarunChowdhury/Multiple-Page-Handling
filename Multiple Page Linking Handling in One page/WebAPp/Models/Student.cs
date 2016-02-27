using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace WebAPp.Models
{
    public class Student
    {
        public int StudentId { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public int CourseId { get; set; } 

        public virtual Course VCourse{ get; set; }

        //public virtual Login VLogin{ get; set; }
        public virtual Department VDepartment{ get; set; } 
    }
}