using BusinessLayer;
using ClassLibrary;
using ClassLibrary.Entity;
using System;
using System.Collections.Generic;

namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Context context = new Context();

            context.Statut.Add(new Statut { Label = "test" });
            context.SaveChanges();*/

            /*try
            {*/
                BusinessManager manager = BusinessManager.Instance;
                manager.AjouterEmployee(new Employee()
                {
                    Nom = "BONJOUR",
                    Prenom = "Bonjour",
                    DateOfBirth = new DateTime()
                });
                List<Employee> employees = manager.GetAllEmployee();
                System.Console.WriteLine("---- LISTE DES EMPLOYEE -----");
                foreach (Employee c in employees)
                {
                    System.Console.WriteLine("Employee ID {0} : {1}", c.Id, c.Nom);
                }

            /*} catch (Exception e) {
                e.ToString();
            }*/
        }
    }
}
