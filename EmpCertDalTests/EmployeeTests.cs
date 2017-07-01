using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmpCertDalTests
{
    using EmpCertDal;

    /// <summary>
    /// The employee tests.
    /// </summary>
    [TestClass]
    public class EmployeeTests
    {
        /// <summary>
        /// The add employee test.
        /// </summary>
        [TestMethod]
        public void AddEmployeeTest()
        {
            EmpCertDal.Employee emp =
                new Employee() { BirthDate = new DateTime(1950, 8, 19), FirstName = "Randy", LastName = "Edge" };
            emp.AddEmployee(emp);
        }

        /// <summary>
        /// The update employee.
        /// </summary>
        [TestMethod]
        public void UpdateEmployee()
        {
           EmpCertDal.Employee emp = new Employee();
          var curEmp =  emp.GetEmployee(1);
            curEmp.PhoneNumber = "xxxxxx";
            emp.UpdateEmployee(curEmp);
        }
    }
}
