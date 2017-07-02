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

    public class Employee: baseConnect

    {
        

    public DateTime BirthDate { get; set; }

    public ICollection<EmployeeCertification> EmployeeCerts { get; set; }

    public string FirstName { get; set; }

    public int Id { get; set; }

    public string LastName { get; set; }

    public string PhoneNumber { get; set; }



    /// <summary>
    ///     The add employee.
    /// </summary>
    /// <param name="newEmployee">
    ///     The new employee.
    /// </param>
    public void AddEmployee(Employee newEmployee)
    {
        cntx.Employees.Add(newEmployee);
        cntx.SaveChanges();
    }

    /// <summary>
    ///     The get employee.
    /// </summary>
    /// <param name="id">
    ///     The id.
    /// </param>
    /// <returns>
    ///     The <see cref="Employee" />.
    /// </returns>
    public Employee GetEmployee(int id)
    {
        return cntx.Employees.FirstOrDefault(a => a.Id == id);
    }

    /// <summary>
    ///     The get employees.
    /// </summary>
    /// <returns>
    ///     The <see cref="List" />.
    /// </returns>
    public List<Employee> GetEmployees()
    {
        return cntx.Employees.ToList();
    }

    /// <summary>
    ///     The update employee.
    /// </summary>
    /// <param name="emp">
    ///     The emp.
    /// </param>
    public void UpdateEmployee(Employee emp)
    {
        cntx.Employees.AddOrUpdate(emp);
        cntx.SaveChanges();
    }

        public Employee() 
        {
        }

    }
}