using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Model
{
    public class BlogCategory
    {
        public int BlogCategoryId { get; set; }
        [Required]
        [Display(Name ="Title")]
        public string CategoryTitle { get; set; }
        [Display(Name = "Description")]
        public string CategoryDescription { get; set; }
        public List<BlogPost> BlogPost { get; set; }
    }
}
