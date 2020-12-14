using System.ComponentModel.DataAnnotations;

namespace DojoSurveyModel.Models
{
    public class Survey
    {
        [Display(Name = "Your Name:  ")]
        [Required(ErrorMessage = "You must enter a name.")]
        [MinLength(2, ErrorMessage = "The name must be at least 2 characters long.")]
        public string Name { get; set; }

        [Display(Name = "Dojo Location:  ")]
        [Required(ErrorMessage = "Must choose a location.")]
        public string Campus { get; set; }

        [Display(Name = "Favorite Language:  ")]
        [Required(ErrorMessage = "Language is required.")]
        public string Language { get; set; }

        [Display(Name = "Comment (Optional):  ")]
        [MaxLength(20, ErrorMessage = "The comment can't be more than 20 characters.")]

        public string Comment { get; set; }
    }
}