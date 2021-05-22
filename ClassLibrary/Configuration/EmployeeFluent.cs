﻿using ClassLibrary.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Configuration
{
    public class EmployeeFluent : EntityTypeConfiguration<Employee>
    {
        public EmployeeFluent()
        {
            ToTable("APP_Employee");
            HasKey(e => e.Id);

            Property(e => e.Id).HasColumnName("EMP_ID ").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.Nom).HasColumnName("EMP_NOM").IsRequired().HasMaxLength(50);
            Property(e => e.Prenom).HasColumnName("EMP_PRENOM").IsRequired().HasMaxLength(50);
            Property(e => e.DateOfBirth).HasColumnName("EMP_DATENAISSANCE");
            Property(e => e.Seniority).HasColumnName("EMP_SENIORITY");
            Property(e => e.Biography).HasColumnName("EMP_BIOGRAPHY");
            
            HasMany(e => e.Experiences).WithRequired(ee => ee.Employee).HasForeignKey(ee => ee.FkEmployee);
            HasMany(e => e.Formations).WithRequired(ee => ee.Employee).HasForeignKey(ee => ee.FkEmployee);
            HasMany(e => e.Postulations).WithRequired(ee => ee.Employee).HasForeignKey(ee => ee.FkEmployee);
        }
    }
}