using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entity
{
    public class Offre
    {
        public int Id { get; set; }

        public string Intitule { get; set; }

        public DateTime Date { get; set; }
        
        public float Salaire { get; set; }

        public string Description { get; set; }

        public string Responsible { get; set; }

        public ICollection<Postulation> Postulations { get; set; }

        public Statut Statut { get; set; }
    }
}
