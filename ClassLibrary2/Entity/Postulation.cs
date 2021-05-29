using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entity
{
    public class Postulation
    {
        public int FkOffre { get; set; }
        public Offre Offre { get; set; }
        public DateTime Date { get; set; }
        public string Statut { get; set; }
        public int FkEmployee { get; set; }
        public Employee Employee { get; set; }

    }
}
