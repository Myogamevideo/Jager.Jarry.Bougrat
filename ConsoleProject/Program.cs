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
                Context context = new Context();
                context.Statuts.Add(new Statut { Label = "Test" });
                context.SaveChanges();
            } catch (Exception e) {
                e.ToString();
            }
            
        }
    }
}
