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
        public List<Offre> GetAllOffres()
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

        #region Employee

        public List<Employee> GetAllEmployees()
        {
            EmployeeQuery eq = new EmployeeQuery(context);
            return eq.GetAll().ToList();
        }

       
        public int AddEmployee(Employee e)
        {
            EmployeeCommand ec = new EmployeeCommand(context);
            return ec.Add(e);
        }

        public void UpdateEmployee(Employee e)
        {
            EmployeeCommand ec = new EmployeeCommand(context);
            ec.Update(e);
        }

         public void DeleteEmployee(int employeeID)
        {
            EmployeeCommand ec = new EmployeeCommand(context);
            ec.Delete(employeeID);
        }
        #endregion

        #region Statut

        public List<Statut> GetAllStatut()
        {
            StatutQuery sq = new StatutQuery(context);
            return sq.GetAll().ToList();
        }

        public Statut GetStatutByID(int id)
        {
            StatutQuery sq = new StatutQuery(context);
            return sq.GetByID(id).FirstOrDefault();
        }
        
        #endregion
    }
}
