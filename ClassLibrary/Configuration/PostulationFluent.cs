using ClassLibrary.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Configuration
{
    public class PostulationFluent : EntityTypeConfiguration<Postulation>
    {
        public PostulationFluent()
        {
            ToTable("APP_Postulation");
            HasKey(p => new { p.FkOffre , p.FkEmployee });            
            
            Property(p => p.Statut).HasColumnName("POS_STATUT").IsRequired();
            Property(p => p.Date).HasColumnName("POS_DATE");

            HasRequired(pp => pp.Employee).WithMany(p => p.Postulations).HasForeignKey(p => p.FkEmployee);
            HasRequired(pp => pp.Offre).WithMany(p => p.Postulations).HasForeignKey(p => p.FkOffre);
        }
    }
}
