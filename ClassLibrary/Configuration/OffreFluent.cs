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
     public class OffreFluent : EntityTypeConfiguration<Offre>
    {
        public OffreFluent()
        {
            ToTable("APP_OFFRE");
            HasKey(o => o.Id);

            Property(o => o.Id).HasColumnName("OFF_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(o => o.Intitule).HasColumnName("OFF_INTITULE").IsRequired().HasMaxLength(50);
            Property(o => o.Date).HasColumnName("OFF_DATE").IsRequired().HasColumnType("datetime2"); ;
            Property(o => o.Salaire).HasColumnName("OFF_SALAIRE").IsRequired();
            Property(o => o.Description).HasColumnName("OFF_DESCRIPTION").IsRequired().HasMaxLength(50);
            Property(o => o.Responsible).HasColumnName("OFF_RESPONSABLE").IsRequired().HasMaxLength(50);
            HasRequired(o => o.Statut);
            HasMany(e => e.Postulations).WithRequired(ee => ee.Offre).HasForeignKey(ee => ee.FkOffre);
        }
    }
}
