using Gianteagle.DTO;
using Microsoft.EntityFrameworkCore;
using System;

namespace Gianteagle.DAL
{
    public class GianteagleDbContext : DbContext
    {
        public GianteagleDbContext(DbContextOptions<GianteagleDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>().HasData(
        //         new User
        //         {
        //             UserId = 1,                     
        //             Name = "Bheem Sen",
        //             CreatedDate=DateTime.Now,
        //             Email="bheemsen.net@gmail.com"
        //         }
        //     );
        //}
    }
}
