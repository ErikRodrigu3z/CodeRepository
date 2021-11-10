using CodeRepository.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CodeRepository
{
    public class DBContext : DbContext
    {  
        string bdPath = Path.Combine(Application.StartupPath, @"DB\CodeRepository.db");

        #region Constructor
        public DBContext()
        {        
            Database.EnsureCreated();
        }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlite(connectionString: "Filename=" + bdPath,
                sqliteOptionsAction:op =>
                {
                    op.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);                    
                });
            base.OnConfiguring(optionbuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Category>(entity => {entity.HasKey(e => e.CategoryID);});
            modelBuilder.Entity<Articles>().ToTable("Articles");
            modelBuilder.Entity<Articles>(entity => { entity.HasKey(e => e.IdArticle); });

            base.OnModelCreating(modelBuilder); 
        }

        #region DbSet
        public DbSet<Category> Category { get; set; }
        public DbSet<Articles> Articles { get; set; }
        #endregion

    }
}
