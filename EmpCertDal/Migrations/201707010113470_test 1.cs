namespace EmpCertDal.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class test1 : DbMigration
    {
        public override void Down()
        {
            this.AddColumn("dbo.Employees", "EmployeeCertification_Id", c => c.Int());
            this.AddColumn("dbo.Certifications", "EmployeeCertification_Id", c => c.Int());
            this.DropForeignKey("dbo.EmployeeCertifications", "Employee_Id", "dbo.Employees");
            this.DropForeignKey("dbo.EmployeeCertifications", "Certification_Id", "dbo.Certifications");
            this.DropIndex("dbo.EmployeeCertifications", new[] { "Employee_Id" });
            this.DropIndex("dbo.EmployeeCertifications", new[] { "Certification_Id" });
            this.DropColumn("dbo.EmployeeCertifications", "Employee_Id");
            this.DropColumn("dbo.EmployeeCertifications", "Certification_Id");
            this.DropColumn("dbo.EmployeeCertifications", "CertificationDate");
            this.CreateIndex("dbo.Employees", "EmployeeCertification_Id");
            this.CreateIndex("dbo.Certifications", "EmployeeCertification_Id");
            this.AddForeignKey("dbo.Employees", "EmployeeCertification_Id", "dbo.EmployeeCertifications", "Id");
            this.AddForeignKey("dbo.Certifications", "EmployeeCertification_Id", "dbo.EmployeeCertifications", "Id");
        }

        public override void Up()
        {
            this.DropForeignKey("dbo.Certifications", "EmployeeCertification_Id", "dbo.EmployeeCertifications");
            this.DropForeignKey("dbo.Employees", "EmployeeCertification_Id", "dbo.EmployeeCertifications");
            this.DropIndex("dbo.Certifications", new[] { "EmployeeCertification_Id" });
            this.DropIndex("dbo.Employees", new[] { "EmployeeCertification_Id" });
            this.AddColumn("dbo.EmployeeCertifications", "CertificationDate", c => c.DateTime(false));
            this.AddColumn("dbo.EmployeeCertifications", "Certification_Id", c => c.Int());
            this.AddColumn("dbo.EmployeeCertifications", "Employee_Id", c => c.Int());
            this.CreateIndex("dbo.EmployeeCertifications", "Certification_Id");
            this.CreateIndex("dbo.EmployeeCertifications", "Employee_Id");
            this.AddForeignKey("dbo.EmployeeCertifications", "Certification_Id", "dbo.Certifications", "Id");
            this.AddForeignKey("dbo.EmployeeCertifications", "Employee_Id", "dbo.Employees", "Id");
            this.DropColumn("dbo.Certifications", "EmployeeCertification_Id");
            this.DropColumn("dbo.Employees", "EmployeeCertification_Id");
        }
    }
}