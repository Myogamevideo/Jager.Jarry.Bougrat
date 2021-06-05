using ClassLibrary;
using ClassLibrary.Entity;
using System;
using System.Linq;

namespace BusinessLayer.Queries
{
    class OffreQuery
    {
        private readonly Context _context;

        public OffreQuery(Context context)
        {
            _context = context;
        }

        public IQueryable<Offre> GetAll()
        {
            return _context.Offres;
        }

        public IQueryable<Offre> GetByID(int id)
        {
            return _context.Offres.Where(o => o.Id == id);
        }
    }
}
