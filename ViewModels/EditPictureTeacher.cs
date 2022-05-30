using System.ComponentModel.DataAnnotations;
using UniversityEnrollment.Models;

namespace UniversityEnrollment.ViewModels
{
    public class EditPictureTeacher
    {
        public Teacher? teacher { get; set; }

        [Display(Name = "Upload picture")]
        public IFormFile? profilePictureFile { get; set; }

        [Display(Name = "Picture name")]
        public string? profilePictureName { get; set; }
    }
}
