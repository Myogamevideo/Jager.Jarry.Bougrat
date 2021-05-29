using BusinessLayer;
using ClassLibrary;
using ClassLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BusinessManager manager = BusinessManager.Instance;
                List<Employee> employees = manager.GetAllEmployee();
                System.Console.WriteLine("---- LISTE DES EMPLOYEE -----");
                foreach (Employee c in employees)
                {
                    System.Console.WriteLine("Employee ID {0} : {1}", c.Id, c.Nom);
                }

            } catch (Exception e) {
                e.ToString();
            }
            
        }
    }
}
