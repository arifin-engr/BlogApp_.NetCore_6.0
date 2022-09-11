using BlogApp.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("server=.;database=ABlogApp; trusted_connection=true");
        //    }
        //}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AppUserImageDetail>(b =>
            {
                b.HasKey(r => new { r.UserId, r.UserImageId });
                b.ToTable("AppUserImageDetails");
            });
            builder.Entity<BlogImageDetail>(b =>
            {
                b.HasKey(r => new { r.PostId, r.BlogImageId });
                b.ToTable("BlogImageDetails");
            });
            foreach (var foreignKey in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.NoAction;

            }
        }

        public DbSet<AppUserImage> AppUserImages { get; set; }
        public DbSet<AppUserImageDetail> AppUserImageDetails { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<BlogImage> BlogImages { get; set; }
        public DbSet<BlogImageDetail> BlogImageDetails { get; set; }


    }
}
