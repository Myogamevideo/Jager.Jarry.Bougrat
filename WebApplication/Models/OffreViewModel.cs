using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class OffreViewModel
    {
        public int Id { get; set; }

        public string Intitule { get; set; }

        public DateTime Date { get; set; }

        public float Salaire { get; set; }

        public string Description { get; set; }

        public string Responsible { get; set; }

        public StatutViewModel Statut { get; set; }
    }
}