using BlogApp.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BlogApp.API
{
    public class SampleContext : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
      public ApplicationDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = configuration.GetConnectionString("con");
            builder.UseSqlServer(connectionString,b=>b.MigrationsAssembly("BlogApp.API"));

            return new  ApplicationDbContext(builder.Options);
        }
    }
}
