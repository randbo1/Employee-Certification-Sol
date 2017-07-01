namespace EmpCertDal.Migrations
{
    using System.Data.Entity.Migrations;

    /// <summary>
    ///     The configuration.
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeCertContext>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Configuration" /> class.
        /// </summary>
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeCertContext context)
        {
        }
    }
}