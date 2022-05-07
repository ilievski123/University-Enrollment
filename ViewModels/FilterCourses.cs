using Microsoft.AspNetCore.Mvc.Rendering;
using UniversityEnrollment.Models;

namespace UniversityEnrollment.ViewModels
{
    public class FilterCourses
    {
        public IList<Course> courses { get; set; }

        public SelectList programmes { get; set; }

        public SelectList semesters { get; set; }

        public string programme { get; set; }

        public string title { get; set; }

        public int semester { get; set; }
    }
}
