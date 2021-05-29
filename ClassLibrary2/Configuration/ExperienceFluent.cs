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
    public class ExperienceFluent : EntityTypeConfiguration<Experience>
    {
        public ExperienceFluent()
        {
            ToTable("APP_EXPERIENCE");
            HasKey(e => e.Id);

            Property(e => e.Id).HasColumnName("EXP_ID ").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.title).HasColumnName("EXP_TITLE").IsRequired().HasMaxLength(50);
            Property(e => e.Date).HasColumnName("EXP_DATE");
            
            HasRequired(ee => ee.Employee).WithMany(e => e.Experiences).HasForeignKey(e => e.FkEmployee);
        }
    }
}
