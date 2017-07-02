namespace EmpCertDal
{
    using System.Data.Entity;

    public class EmployeeCertContext : DbContext
    {
        public EmployeeCertContext()
            : base("Data Source=RANDY-ASUS;Initial Catalog=EmployeeCertDb;Integrated Security=True; ")
        {
        }

        /// <summary>
        ///     Gets or sets the certifications.
        /// </summary>
        public DbSet<Certification> Certifications { get; set; }

        /// <summary>
        ///     Gets or sets the employee certifications.
        /// </summary>
        public DbSet<EmployeeCertification> EmployeeCertifications { get; set; }

        /// <summary>
        ///     Gets or sets the employees.
        /// </summary>
        public DbSet<Employee> Employees { get; set; }

        /// <summary>
        ///     Gets or sets the equipment list.
        /// </summary>
        public DbSet<Equipment> EquipmentList { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Property(x => x.BirthDate).HasColumnName("Birth Date");
            modelBuilder.Entity<Employee>().Property(x => x.BirthDate).IsOptional();
            modelBuilder.Entity<EmployeeCertification>().Ignore(x => x.IsValid);
        }
    }
}