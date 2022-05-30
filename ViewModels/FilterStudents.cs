using Microsoft.AspNetCore.Mvc.Rendering;
using UniversityEnrollment.Models;

namespace UniversityEnrollment.ViewModels
{
    public class FilterStudents
    {
        public IList<Student> students { get; set; }

        public string fullName { get; set; }

        public string studentId { get; set; }
        public SelectList yearsList { get; set; }
         
        public DateTime? year { get; set; }
    }
}
