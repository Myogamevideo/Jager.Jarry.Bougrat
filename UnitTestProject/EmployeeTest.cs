using System;
using System.Collections.Generic;
using BusinessLayer;
using ClassLibrary.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void GetEmployee_ReturnsAll()
        {
            BusinessManager m = BusinessManager.Instance;
            var produits = m.GetAllEmployee();
            Assert.IsNotNull(produits != null);
            Assert.IsInstanceOfType(produits, typeof(List<Employee>));
        }
    }
}
