namespace EmpCertDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeCertificationAddRefactor : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmployeeCertifications", "Certification_Id", "dbo.Certifications");
            DropForeignKey("dbo.EmployeeCertifications", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.EmployeeCertifications", new[] { "Certification_Id" });
            DropIndex("dbo.EmployeeCertifications", new[] { "Employee_Id" });
            RenameColumn(table: "dbo.EmployeeCertifications", name: "Certification_Id", newName: "CertId");
            RenameColumn(table: "dbo.EmployeeCertifications", name: "Employee_Id", newName: "EmployeeId");
            AlterColumn("dbo.EmployeeCertifications", "CertId", c => c.Int(nullable: false));
            AlterColumn("dbo.EmployeeCertifications", "EmployeeId", c => c.Int(nullable: false));
            CreateIndex("dbo.EmployeeCertifications", "EmployeeId");
            CreateIndex("dbo.EmployeeCertifications", "CertId");
            AddForeignKey("dbo.EmployeeCertifications", "CertId", "dbo.Certifications", "Id", cascadeDelete: true);
            AddForeignKey("dbo.EmployeeCertifications", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeCertifications", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.EmployeeCertifications", "CertId", "dbo.Certifications");
            DropIndex("dbo.EmployeeCertifications", new[] { "CertId" });
            DropIndex("dbo.EmployeeCertifications", new[] { "EmployeeId" });
            AlterColumn("dbo.EmployeeCertifications", "EmployeeId", c => c.Int());
            AlterColumn("dbo.EmployeeCertifications", "CertId", c => c.Int());
            RenameColumn(table: "dbo.EmployeeCertifications", name: "EmployeeId", newName: "Employee_Id");
            RenameColumn(table: "dbo.EmployeeCertifications", name: "CertId", newName: "Certification_Id");
            CreateIndex("dbo.EmployeeCertifications", "Employee_Id");
            CreateIndex("dbo.EmployeeCertifications", "Certification_Id");
            AddForeignKey("dbo.EmployeeCertifications", "Employee_Id", "dbo.Employees", "Id");
            AddForeignKey("dbo.EmployeeCertifications", "Certification_Id", "dbo.Certifications", "Id");
        }
    }
}
