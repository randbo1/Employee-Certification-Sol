using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpCertDal
{
    using System.Data.Entity;
    using System.Security.Cryptography.X509Certificates;

    public class EmployeeCertContext:DbContext
    {
        public EmployeeCertContext()
            :base("Data Source=RANDY-ASUS;Initial Catalog=EmployeeCertDb;Integrated Security=True; ")
        {
        }

        /// <summary>
        /// Gets or sets the employees.
        /// </summary>
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Property(x => x.BirthDate).HasColumnName("Birth Date");
        }

        /// <summary>
        /// Gets or sets the equipment list.
        /// </summary>
        public DbSet<Equipment> EquipmentList { get; set; }

        /// <summary>
        /// Gets or sets the certifications.
        /// </summary>
        public DbSet<Certification> Certifications{ get; set; }

        /// <summary>
        /// Gets or sets the employee certifications.
        /// </summary>
        public DbSet<EmployeeCertification> EmployeeCertifications { get; set; }
    }
}
