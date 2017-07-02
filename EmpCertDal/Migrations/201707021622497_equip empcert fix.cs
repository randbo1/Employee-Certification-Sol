namespace EmpCertDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class equipempcertfix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Equipments", "EmployeeCertification_Id", "dbo.EmployeeCertifications");
            DropIndex("dbo.Equipments", new[] { "EmployeeCertification_Id" });
            AddColumn("dbo.EmployeeCertifications", "Equipment_Id", c => c.Int());
            CreateIndex("dbo.EmployeeCertifications", "Equipment_Id");
            AddForeignKey("dbo.EmployeeCertifications", "Equipment_Id", "dbo.Equipments", "Id");
            DropColumn("dbo.Equipments", "EmployeeCertification_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Equipments", "EmployeeCertification_Id", c => c.Int());
            DropForeignKey("dbo.EmployeeCertifications", "Equipment_Id", "dbo.Equipments");
            DropIndex("dbo.EmployeeCertifications", new[] { "Equipment_Id" });
            DropColumn("dbo.EmployeeCertifications", "Equipment_Id");
            CreateIndex("dbo.Equipments", "EmployeeCertification_Id");
            AddForeignKey("dbo.Equipments", "EmployeeCertification_Id", "dbo.EmployeeCertifications", "Id");
        }
    }
}
