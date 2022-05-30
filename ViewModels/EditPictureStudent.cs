using System.ComponentModel.DataAnnotations;
using UniversityEnrollment.Models;

namespace UniversityEnrollment.ViewModels
{
    public class EditPictureStudent
    {
        public Student? student { get; set; }

        [Display(Name = "Upload picture")]
        public IFormFile? profilePictureFile { get; set; }

        [Display(Name = "Picture name")]
        public string? profilePictureName { get; set; }
    }
}
