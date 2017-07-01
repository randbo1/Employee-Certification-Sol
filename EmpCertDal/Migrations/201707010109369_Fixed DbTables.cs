namespace EmpCertDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedDbTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Certifications", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.Certifications", new[] { "Employee_Id" });
            DropColumn("dbo.Certifications", "Employee_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Certifications", "Employee_Id", c => c.Int());
            CreateIndex("dbo.Certifications", "Employee_Id");
            AddForeignKey("dbo.Certifications", "Employee_Id", "dbo.Employees", "Id");
        }
    }
}
