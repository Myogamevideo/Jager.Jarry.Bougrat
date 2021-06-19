using ClassLibrary;
using ClassLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Commands
{
    class StatutCommand
    {
        private readonly Context _context;

        public StatutCommand(Context context)
        {
            _context = context;
        }

        public int Add(Statut statut)
        {
            _context.Statut.Add(statut);
            return _context.SaveChanges();
        }

        public void Update(Statut statut)
        {
            Statut updatedStatut = _context.Statut.Where(s => s.Id == statut.Id).FirstOrDefault();
            if (updatedStatut != null)
            {
                updatedStatut.Label = statut.Label;
            }

            _context.SaveChanges();
        }

        public void Delete(int statutID)
        {
            Statut statutToDel = _context.Statut.Where(o => o.Id == statutID).FirstOrDefault();
            if (statutToDel != null)
            {
                _context.Statut.Remove(statutToDel);
            }

            _context.SaveChanges();
        }
    }
}
