using ClassLibrary;
using ClassLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    class EmployeeQuery
    {
        private readonly Context _contexte;

       public EmployeeQuery(Context contexte)
        {
            _contexte = contexte;
        }

        public IQueryable<Employee> GetAll()
        {
            return _contexte.Employees;
        }

        public IQueryable<Employee> GetByID(int id)
        {
            return _contexte.Employees.Where(p => p.Id == id);
        }
    }
}
