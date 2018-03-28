using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetIncident.Core.Model;

namespace ProjetIncident.core.DataAccess
{
    public class IncidentDbContext : DbContext
    {

        #region Singleton

        private static IncidentDbContext _context = null;

        public async static Task<IncidentDbContext> GetCurrent(){
            if(_context == null){
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "incident.db");
                await _context.Database.MigrateAsync();
            }
            return _context;
        }

		#endregion

        public String DatabasePath { get; }
		public DbSet<User> Users { get; set; }
		public DbSet<Incident> Incidents { get; set; }
		public DbSet<Category> Categoryies { get; set; }
		public DbSet<Photo> Photos { get; set; }

        private IncidentDbContext(string databasePath)
        {
            DatabasePath = databasePath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Filename={DatabasePath}");
        }
    }
}
