using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace BlogApp.Model
{
    public class AppUser:IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Gender Gender { get; set; }=Gender.Male;
        public string? Country { get; set; }
        public int? UserImageId { get; set; }
        public AppUserImage? AppUserImage { get; set; }
    }
    public class AppUserImage
    {
        [Key]
        public int UserImageId { get; set; }
        public string ImageName { get; set; }
    }
    public class AppUserImageDetail
    {
        [ForeignKey("AppUser")]
        public string UserId { get; set; }
        public  AppUser AppUser { get; set; }
        [ForeignKey("AppUserImage")]
        public int UserImageId { get; set; }
        public AppUserImage AppUserImage { get; set; }
    }
    public enum Gender
    {
        Male,
        Female,
        Others
    }
}
