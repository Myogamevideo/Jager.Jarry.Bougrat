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
    class FormationFluent : EntityTypeConfiguration<Formation>
    {
        public FormationFluent()
        {
            ToTable("APP_Formation");
            HasKey(e => e.Id);

            Property(f => f.Id).HasColumnName("EMP_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(f => f.Title).HasColumnName("FOR_INTITULE").IsRequired();
            Property(f => f.Date).HasColumnName("FOR_DATE");
            
            HasRequired(ff => ff.Employee).WithMany(f => f.Formations).HasForeignKey(c => c.FkEmployee);

        }
    }
}
