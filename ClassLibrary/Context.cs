using ClassLibrary.Configuration;
using ClassLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Context : DbContext
    {
        public Context() : base("name=cs")
        {
            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Configurations.Add(new EmployeeFluent());
            modelBuilder.Configurations.Add(new ExperienceFluent());
            modelBuilder.Configurations.Add(new FormationFluent());
            modelBuilder.Configurations.Add(new OffreFluent());
            modelBuilder.Configurations.Add(new PostulationFluent());
            modelBuilder.Configurations.Add(new StatutFluent());
        }

        public IDbSet<Employee> Employees { get; set; }
        public IDbSet<Experience> Experiences { get; set; }
        public IDbSet<Formation> Formations { get; set; }
        public IDbSet<Offre> Offres { get; set; }
        public IDbSet<Postulation> Postulations { get; set; }
        public IDbSet<Statut> Statut { get; set; }
    }
}
