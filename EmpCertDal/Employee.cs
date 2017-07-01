namespace EmpCertDal
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    ///     The employee.
    /// </summary>
    [SuppressMessage(
        "StyleCop.CSharp.LayoutRules",
        "SA1509:OpeningCurlyBracketsMustNotBePrecededByBlankLine",
        Justification = "Reviewed. Suppression is OK here.")]
    public class Employee
    {
        public DateTime BirthDate { get; set; }

        public ICollection<EmployeeCertification> EmployeeCerts { get; set; }

        public string FirstName { get; set; }

        public int Id { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public void AddEmployee(Employee newEmployee)
        {
            var cntx = new EmployeeCertContext();

            cntx.Employees.Add(newEmployee);
            cntx.SaveChanges();
        }

        public Employee GetEmployee(int id)
        {
            var cntx = new EmployeeCertContext();

            return cntx.Employees.FirstOrDefault(a => a.Id == id);
        }

        public void UpdateEmployee(Employee emp)
        {
            var cntx = new EmployeeCertContext();

            cntx.Employees.AddOrUpdate(emp);
            cntx.SaveChanges();
        }
    }
}