using ClassLibrary;
using ClassLibrary.Entity;
using System;

namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.Statut.Add(new Statut { Label = "Test" });
            context.SaveChanges();
        }
    }
}
