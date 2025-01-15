using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.ApplicationServices;

namespace GatewayToTheWorldOfMusic.Data
{
    internal class AppDbContext : DbContext
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        //{
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Your Connection String");
        //}
       
        //protected readonly IConfiguration configuration;

        public AppDbContext(/*IConfiguration configuration*/)
        {
            //this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=gateway;Username=postgres;Password=password"/*configuration.GetConnectionString("DefaultConnection")*/);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
    }
}
