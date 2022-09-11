using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Model
{
    public class BlogPost
    {
        [Key]
        public int PostId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Post { get; set; }
        [Required]
        [Display(Name = "Create Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}", ApplyFormatInEditMode = true)]
        public DateTime CreateDate { get; set; }
        [Display(Name = "Modified Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}", ApplyFormatInEditMode = true)]
        public DateTime ModifiedDate { get; set; }
        public int BlogImageId { get; set; }
        public BlogImage? BlogImage { get; set; }
    }
   public class BlogImage
    {
        [Key]
        public int BlogImageId { get; set; }
        public string BlogImageTitle { get; set; }
    }
    public class BlogImageDetail
    {
        [ForeignKey("BlogPost")]
        public int PostId { get; set; }
        [ForeignKey("BlogImage")]
        public int BlogImageId { get; set; }
        public BlogPost BlogPost { get; set; }
        public BlogImage BlogImage { get; set; }
    }
}
