using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Seniority { get; set; }
        public string Biography { get; set; }

        public ICollection<Experience> Experiences { get; set; }
        public ICollection<Postulation> Postulations { get; set; }
        public ICollection<Formation> Formations { get; set; }
    }
}
