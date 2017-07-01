using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmpCertDal
{
    using System.Data.Entity.Migrations;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The employee.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1509:OpeningCurlyBracketsMustNotBePrecededByBlankLine", Justification = "Reviewed. Suppression is OK here.")]
    public class Employee
   
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }


        public void AddEmployee(Employee newEmployee)
        {
            EmployeeCertContext cntx = new EmployeeCertContext();

            cntx.Employees.Add(newEmployee);
            cntx.SaveChanges();
        }

        public void UpdateEmployee(Employee emp)
        {
            EmployeeCertContext cntx =new EmployeeCertContext();

            cntx.Employees.AddOrUpdate(emp);
            cntx.SaveChanges();
        }

        public Employee GetEmployee(int id)
        {
            EmployeeCertContext cntx = new EmployeeCertContext();

          return  cntx.Employees.FirstOrDefault(a => a.Id == id);
        }

        public ICollection<EmployeeCertification> EmployeeCerts { get; set; }


    }
}
