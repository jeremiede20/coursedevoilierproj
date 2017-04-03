using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseVoiliers.Classes
{
    public class DbCourseVoiliersContext : DbContext
    {
        
        public DbCourseVoiliersContext() : base("Projet_VOILIERS")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }



        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<EnCourse> EnCourse { get; set; }
        public virtual DbSet<Epreuve> Epreuves { get; set; }
        public virtual DbSet<Historique> Historique { get; set; }
        public virtual DbSet<Penalite> Penalites { get; set; }
        public virtual DbSet<Personne> Personnes { get; set; }
        public virtual DbSet<Sponsor> Sponsors { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
        public virtual DbSet<Voilier> Voiliers { get; set; }
    }
}
