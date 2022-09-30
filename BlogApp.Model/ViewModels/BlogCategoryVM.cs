using System.ComponentModel.DataAnnotations;

namespace BlogApp.Model.ViewModels
{
    public class BlogCategoryVM
    {
        
        public int BlogCategoryId { get; set; }
        [Required]
        [Display(Name = "Title")]
        public string CategoryTitle { get; set; }
        [Display(Name = "Description")]
        public string CategoryDescription { get; set; }
    }
}
