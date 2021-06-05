using ClassLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewProject.Mock
{
    class BusinessManagerMock
    {
        private static BusinessManagerMock _businessManager = null;
        
        private BusinessManagerMock()
        {
        }

        public static BusinessManagerMock Instance
        {
            get
            {
                if (_businessManager == null)
                    _businessManager = new BusinessManagerMock();
                return _businessManager;
            }
        }

        public List<Employee> GetAllEmployee()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 245, Nom = "Huile d'olive végétale" });
            employees.Add(new Employee { Id = 321, Nom = "Magrets de canard" });
            employees.Add(new Employee { Id = 45, Nom = "Terrine de truite" });
            return employees;
        }
    }
}
