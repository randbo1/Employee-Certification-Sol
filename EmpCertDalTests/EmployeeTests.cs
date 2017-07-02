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
            EmployeeCertContext cntx = new EmployeeCertContext();
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
            EmployeeCertContext cntx = new EmployeeCertContext();
            EmpCertDal.Employee emp = new Employee( );
            var curEmp = emp.GetEmployee(10);
            curEmp.PhoneNumber = "80`7500057";
            emp.UpdateEmployee(curEmp);
           
           
        }
    }
}
