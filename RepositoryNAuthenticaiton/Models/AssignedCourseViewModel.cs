using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryNAuthenticaiton.Models
{
    public class AssignedCourseViewModel
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public bool Assigned { get; set; }
    }
    //public class AssignedCourseData
    //{
    //    public int CourseID { get; set; }
    //    public string Title { get; set; }
    //    public bool Assigned { get; set; }
    //}
}