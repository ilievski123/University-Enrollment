using System.ComponentModel.DataAnnotations;
using UniversityEnrollment.Models;

namespace UniversityEnrollment.ViewModels
{
    public class EditAsStudent
    {
        public Enrollment enrollment { get; set; }

        [Display(Name = "Seminal File")]
        public IFormFile? seminalUrlFile { get; set; }

        public string? seminalUrlName { get; set; }
    }
}
