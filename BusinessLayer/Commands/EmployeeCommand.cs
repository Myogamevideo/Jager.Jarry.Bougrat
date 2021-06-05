using ClassLibrary;
using ClassLibrary.Entity;
using System.Linq;

namespace BusinessLayer.Commands
{
    class EmployeeCommand
    {
        private readonly Context _contexte;

        public EmployeeCommand(Context contexte)
        {
            _contexte = contexte;
        }

        public int Add(Employee e)
        {
            _contexte.Employees.Add(e);
            return _contexte.SaveChanges();
        }

        public void Update(Employee e)
        {
            Employee upEmp = _contexte.Employees.Where(emp => emp.Id == e.Id).FirstOrDefault();
            if (upEmp != null)
            {
                upEmp.Nom = e.Nom;
            }
            _contexte.SaveChanges();
        }

        public void Delete(int employeeID)
        {
            Employee delEmp = _contexte.Employees.Where(emp => emp.Id == employeeID).FirstOrDefault();
            if (delEmp != null)
            {
                _contexte.Employees.Remove(delEmp);
            }
            _contexte.SaveChanges();
        }
    }
}
