using ClassLibrary;
using ClassLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Commands
{
    class OffreCommand
    {
        private readonly Context _context;

        public OffreCommand(Context context)
        {
            _context = context;
        }

        public int Add(Offre offre)
        {
            _context.Offres.Add(offre);
            return _context.SaveChanges();
        }

        public void Update(Offre offre)
        {
            Offre updatedOffre = _context.Offres.Where(o => o.Id == offre.Id).FirstOrDefault();
            if(updatedOffre != null)
            {
                updatedOffre.Intitule = offre.Intitule;
                updatedOffre.Salaire = offre.Salaire;
                // TODO
            }

            _context.SaveChanges();
        }

        public void Delete(int offreID)
        {
            Offre offreToDel = _context.Offres.Where(o => o.Id == offreID).FirstOrDefault();
            if(offreToDel != null)
            {
                _context.Offres.Remove(offreToDel);
            }

            _context.SaveChanges();
        }
    }
}
