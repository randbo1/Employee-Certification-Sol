namespace EmpCertDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeCertsAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeCertifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Certifications", "EmployeeCertification_Id", c => c.Int());
            AddColumn("dbo.Certifications", "Employee_Id", c => c.Int());
            AddColumn("dbo.Employees", "EmployeeCertification_Id", c => c.Int());
            CreateIndex("dbo.Certifications", "EmployeeCertification_Id");
            CreateIndex("dbo.Certifications", "Employee_Id");
            CreateIndex("dbo.Employees", "EmployeeCertification_Id");
            AddForeignKey("dbo.Certifications", "EmployeeCertification_Id", "dbo.EmployeeCertifications", "Id");
            AddForeignKey("dbo.Certifications", "Employee_Id", "dbo.Employees", "Id");
            AddForeignKey("dbo.Employees", "EmployeeCertification_Id", "dbo.EmployeeCertifications", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "EmployeeCertification_Id", "dbo.EmployeeCertifications");
            DropForeignKey("dbo.Certifications", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Certifications", "EmployeeCertification_Id", "dbo.EmployeeCertifications");
            DropIndex("dbo.Employees", new[] { "EmployeeCertification_Id" });
            DropIndex("dbo.Certifications", new[] { "Employee_Id" });
            DropIndex("dbo.Certifications", new[] { "EmployeeCertification_Id" });
            DropColumn("dbo.Employees", "EmployeeCertification_Id");
            DropColumn("dbo.Certifications", "Employee_Id");
            DropColumn("dbo.Certifications", "EmployeeCertification_Id");
            DropTable("dbo.EmployeeCertifications");
        }
    }
}
