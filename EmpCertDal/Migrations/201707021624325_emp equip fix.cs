namespace EmpCertDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class empequipfix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmployeeCertifications", "Equipment_Id", "dbo.Equipments");
            DropIndex("dbo.EmployeeCertifications", new[] { "Equipment_Id" });
            DropColumn("dbo.EmployeeCertifications", "Equipment_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmployeeCertifications", "Equipment_Id", c => c.Int());
            CreateIndex("dbo.EmployeeCertifications", "Equipment_Id");
            AddForeignKey("dbo.EmployeeCertifications", "Equipment_Id", "dbo.Equipments", "Id");
        }
    }
}
