using CrmEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrmData.Concrete
{
    public class DataContext:DbContext
    {
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<calisan> calisans { get; set; }
        public virtual DbSet<Category> categories { get; set; }
        public virtual DbSet<CompanyCategory> companyCategories { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<Gorev> gorevs { get; set; }
        public virtual DbSet<Muhasebe> muhasebes { get; set; }
        public virtual DbSet<Note> notes { get; set; }
        public virtual DbSet<deneme> denemeler { get; set; }
        public virtual DbSet<il> iller { get; set; }
        public virtual DbSet<denemeil> denemeiller { get; set; }
        public virtual DbSet<notify> notify { get; set; }
        public  DataContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-39583MR\SQLEXPRESS;Initial Catalog=CrmData;Integrated Security=SSPI");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyCategory>()
                .HasKey(c => new { c.categoryId, c.companyId });
            modelBuilder.Entity<denemeil>()
                .HasKey(x => new { x.denemeId, x.ilId });
            
        }

    }


}
