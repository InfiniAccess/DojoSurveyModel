using System.ComponentModel.DataAnnotations;

namespace DojoSurveyModel.Models
{
    public class Survey
    {
        [Display(Name = "Your Name:  ")]
        public string Name { get; set; }

        [Display(Name = "Dojo Location:  ")]
        public string Campus { get; set; }

        [Display(Name = "Favorite Language:  ")]
        public string Language { get; set; }

        [Display(Name = "Comment (Optional):  ")]
        public string Comment { get; set; }
    }
}