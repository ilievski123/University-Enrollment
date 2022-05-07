using Microsoft.AspNetCore.Mvc.Rendering;
using UniversityEnrollment.Models;

namespace UniversityEnrollment.ViewModels
{
    public class FilterEnrollments
    {
        public IList<Enrollment> Enrollments { get; set; }

        public SelectList yearsList { get; set; }
        public int year { get; set; }
    }
}
