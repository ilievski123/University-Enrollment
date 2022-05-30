using Microsoft.AspNetCore.Mvc.Rendering;
using UniversityEnrollment.Models;

namespace UniversityEnrollment.ViewModels
{
    public class TeacherStudent
    {
        public List<Enrollment> Enrolls { get; set; }
        public SelectList YearList { get; set; }
        public int? Year { get; set; }
    }
}
