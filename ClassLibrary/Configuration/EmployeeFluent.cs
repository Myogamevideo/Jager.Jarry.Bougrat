 using ClassLibrary.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ClassLibrary.Configuration
{
    public class EmployeeFluent : EntityTypeConfiguration<Employee>
    {
        public EmployeeFluent()
        {
            ToTable("APP_EMPLOYEE");
            HasKey(e => e.Id);

            Property(e => e.Id).HasColumnName("EMP_ID ").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.Nom).HasColumnName("EMP_NOM").IsRequired().HasMaxLength(50);
            Property(e => e.Prenom).HasColumnName("EMP_PRENOM").IsRequired().HasMaxLength(50);
            Property(e => e.DateOfBirth).HasColumnName("EMP_DATENAISSANCE").HasColumnType("datetime2");
            Property(e => e.Seniority).HasColumnName("EMP_SENIORITY");
            Property(e => e.Biography).HasColumnName("EMP_BIOGRAPHY");
            
            HasMany(e => e.Experiences).WithRequired(ee => ee.Employee).HasForeignKey(ee => ee.FkEmployee);
            HasMany(e => e.Formations).WithRequired(ee => ee.Employee).HasForeignKey(ee => ee.FkEmployee);
            HasMany(e => e.Postulations).WithRequired(ee => ee.Employee).HasForeignKey(ee => ee.FkEmployee);
        }
    }
}
