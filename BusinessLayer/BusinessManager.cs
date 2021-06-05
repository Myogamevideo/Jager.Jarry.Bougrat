using BusinessLayer.Commands;
using BusinessLayer.Queries;
using ClassLibrary;
using ClassLibrary.Entity;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class BusinessManager
    {
        private readonly Context context;
        private static BusinessManager _businessManager = null;

        private BusinessManager()
        {
            context = new Context();
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



        #region Offres
        public List<Offre> GetAllOffre()
        {
            OffreQuery oq = new OffreQuery(context);
            return oq.GetAll().ToList();
        }


        public int AddOffre(Offre o)
        {
            OffreCommand oc = new OffreCommand(context);
            return oc.Add(o);
        }

        public void UpdateOffre(Offre o)
        {
            OffreCommand oc = new OffreCommand(context);
            oc.Update(o);
        }

        public void DeleteOffre(int offreID)
        {
            OffreCommand oc = new OffreCommand(context);
            oc.Delete(offreID);
        }
        #endregion

        // TODO: SUPPR
        #region Employee

        public List<Employee> GetAllEmployee()
        {
            EmployeeQuery eq = new EmployeeQuery(context);
            return eq.GetAll().ToList();
        }

       
        public int AjouterEmployee(Employee e)
        {
            EmployeeCommand ec = new EmployeeCommand(context);
            return ec.Ajouter(e);
        }

        public void ModifierEmployee(Employee e)
        {
            EmployeeCommand ec = new EmployeeCommand(context);
            ec.Modifier(e);
        }

         public void SupprimerEmployee(int employeeID)
        {
            EmployeeCommand ec = new EmployeeCommand(context);
            ec.Supprimer(employeeID);
        }
        #endregion

    }
}
