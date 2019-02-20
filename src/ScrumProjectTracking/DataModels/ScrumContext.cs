using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace ScrumProjectTracking.DataModels
{
    public class ScrumContext : DbContext

    {
        public DbSet<Team> Teams { get; set;}
        public DbSet<Sprint> Sprints { get; set;} 
        public DbSet<SprintTask> SprintTasks { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=den1.mssql7.gear.host;Initial Catalog=scrumbuckets;Persist Security Info=True;User ID=scrumbuckets;Password=scrum8080!;MultipleActiveResultSets=True");
            base.OnConfiguring(dbContextOptionsBuilder);


        }

    
    }
}
