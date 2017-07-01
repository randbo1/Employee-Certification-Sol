namespace EmpCertDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Certifications", "EmployeeCertification_Id", "dbo.EmployeeCertifications");
            DropForeignKey("dbo.Employees", "EmployeeCertification_Id", "dbo.EmployeeCertifications");
            DropIndex("dbo.Certifications", new[] { "EmployeeCertification_Id" });
            DropIndex("dbo.Employees", new[] { "EmployeeCertification_Id" });
            AddColumn("dbo.EmployeeCertifications", "CertificationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.EmployeeCertifications", "Certification_Id", c => c.Int());
            AddColumn("dbo.EmployeeCertifications", "Employee_Id", c => c.Int());
            CreateIndex("dbo.EmployeeCertifications", "Certification_Id");
            CreateIndex("dbo.EmployeeCertifications", "Employee_Id");
            AddForeignKey("dbo.EmployeeCertifications", "Certification_Id", "dbo.Certifications", "Id");
            AddForeignKey("dbo.EmployeeCertifications", "Employee_Id", "dbo.Employees", "Id");
            DropColumn("dbo.Certifications", "EmployeeCertification_Id");
            DropColumn("dbo.Employees", "EmployeeCertification_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "EmployeeCertification_Id", c => c.Int());
            AddColumn("dbo.Certifications", "EmployeeCertification_Id", c => c.Int());
            DropForeignKey("dbo.EmployeeCertifications", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.EmployeeCertifications", "Certification_Id", "dbo.Certifications");
            DropIndex("dbo.EmployeeCertifications", new[] { "Employee_Id" });
            DropIndex("dbo.EmployeeCertifications", new[] { "Certification_Id" });
            DropColumn("dbo.EmployeeCertifications", "Employee_Id");
            DropColumn("dbo.EmployeeCertifications", "Certification_Id");
            DropColumn("dbo.EmployeeCertifications", "CertificationDate");
            CreateIndex("dbo.Employees", "EmployeeCertification_Id");
            CreateIndex("dbo.Certifications", "EmployeeCertification_Id");
            AddForeignKey("dbo.Employees", "EmployeeCertification_Id", "dbo.EmployeeCertifications", "Id");
            AddForeignKey("dbo.Certifications", "EmployeeCertification_Id", "dbo.EmployeeCertifications", "Id");
        }
    }
}
