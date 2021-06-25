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

            BusinessManager manager = BusinessManager.Instance;
            //manager.AddStatut(new Statut(){Label = "Ouverte"});

            //manager.GetAllStatut()[0],

            /*manager.AddOffre(new Offre()
            {
                Intitule = "Offre 1",
                Description = "Une première offre",
                Salaire = 1500,
                Date = new DateTime(),
                Responsible = "Moi",
                Statut = manager.GetAllStatut()[0],
                Postulations = new List<Postulation>()
            });*/

            /*Context context = new Context();

            context.Statut.Add(new Statut { Label = "test" });
            context.SaveChanges();*/

            /*try
            {
                BusinessManager manager = BusinessManager.Instance;
                manager.AddEmployee(new Employee()
                {
                    Nom = "BONJOUR",
                    Prenom = "Bonjour",
                    DateOfBirth = new DateTime()
                });
                List<Employee> employees = manager.GetAllEmployees();
                System.Console.WriteLine("---- LISTE DES EMPLOYEE -----");
                foreach (Employee c in employees)
                {
                    System.Console.WriteLine("Employee ID {0} : {1}", c.Id, c.Nom);
                }

            } catch (Exception e) {
                e.ToString();
            }*/
        }
    }
}
