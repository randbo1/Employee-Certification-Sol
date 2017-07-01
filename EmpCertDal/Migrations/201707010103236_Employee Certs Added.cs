namespace EmpCertDal.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class EmployeeCertsAdded : DbMigration
    {
        public override void Down()
        {
            this.DropForeignKey("dbo.Employees", "EmployeeCertification_Id", "dbo.EmployeeCertifications");
            this.DropForeignKey("dbo.Certifications", "Employee_Id", "dbo.Employees");
            this.DropForeignKey("dbo.Certifications", "EmployeeCertification_Id", "dbo.EmployeeCertifications");
            this.DropIndex("dbo.Employees", new[] { "EmployeeCertification_Id" });
            this.DropIndex("dbo.Certifications", new[] { "Employee_Id" });
            this.DropIndex("dbo.Certifications", new[] { "EmployeeCertification_Id" });
            this.DropColumn("dbo.Employees", "EmployeeCertification_Id");
            this.DropColumn("dbo.Certifications", "Employee_Id");
            this.DropColumn("dbo.Certifications", "EmployeeCertification_Id");
            this.DropTable("dbo.EmployeeCertifications");
        }

        public override void Up()
        {
            this.CreateTable("dbo.EmployeeCertifications", c => new { Id = c.Int(false, true) }).PrimaryKey(t => t.Id);

            this.AddColumn("dbo.Certifications", "EmployeeCertification_Id", c => c.Int());
            this.AddColumn("dbo.Certifications", "Employee_Id", c => c.Int());
            this.AddColumn("dbo.Employees", "EmployeeCertification_Id", c => c.Int());
            this.CreateIndex("dbo.Certifications", "EmployeeCertification_Id");
            this.CreateIndex("dbo.Certifications", "Employee_Id");
            this.CreateIndex("dbo.Employees", "EmployeeCertification_Id");
            this.AddForeignKey("dbo.Certifications", "EmployeeCertification_Id", "dbo.EmployeeCertifications", "Id");
            this.AddForeignKey("dbo.Certifications", "Employee_Id", "dbo.Employees", "Id");
            this.AddForeignKey("dbo.Employees", "EmployeeCertification_Id", "dbo.EmployeeCertifications", "Id");
        }
    }
}