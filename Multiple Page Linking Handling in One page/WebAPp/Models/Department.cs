using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace WebAPp.Models
{
    public class Department
    {
        public int DepartmentId { get; set; } 
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Student>  VDepartment{ get; set; }  
        public virtual ICollection<Course>  VCourses{ get; set; } 

    }
}