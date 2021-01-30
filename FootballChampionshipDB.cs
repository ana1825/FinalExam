using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FootballChempionship
{
    
    public class FootballChampionshipDB : DbContext
    {
        public DbSet<FootballTeam> footballTeams { get; set; }
        public DbSet<Championship> championships { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=FootbalChampionshipDb;Integrated security=true;");
        }
        
    }
}
