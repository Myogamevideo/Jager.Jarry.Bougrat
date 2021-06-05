using ClassLibrary;
using ClassLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    class StatutQuery
    {
        private readonly Context _context;

        public StatutQuery(Context context)
        {
            _context = context;
        }

        public IQueryable<Statut> GetAll()
        {
            return _context.Statut;
        }

        public IQueryable<Statut> GetByID(int id)
        {
            return _context.Statut.Where(s => s.Id == id);
        }
    }
}
