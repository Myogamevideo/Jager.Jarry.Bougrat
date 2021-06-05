using BusinessLayer.Commands;
using BusinessLayer.Queries;
using ClassLibrary;
using ClassLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessManager
    {
        private readonly Context contexte;
        private static BusinessManager _businessManager = null;

        private BusinessManager()
        {
            contexte = new Context();
        }

        public static BusinessManager Instance
        {
            get
            {
                if (_businessManager == null)
                    _businessManager = new BusinessManager();
                return _businessManager;
            }
        }

        #region Employee

        public List<Employee> GetAllEmployee()
        {
            EmployeeQuery eq = new EmployeeQuery(contexte);
            return eq.GetAll().ToList();
        }

       
        public int AjouterEmployee(Employee e)
        {
            EmployeeCommand ec = new EmployeeCommand(contexte);
            return ec.Ajouter(e);
        }

        public void ModifierEmployee(Employee e)
        {
            EmployeeCommand ec = new EmployeeCommand(contexte);
            ec.Modifier(e);
        }

         public void SupprimerEmployee(int employeeID)
        {
            EmployeeCommand ec = new EmployeeCommand(contexte);
            ec.Supprimer(employeeID);
        }
        #endregion

    }
}
