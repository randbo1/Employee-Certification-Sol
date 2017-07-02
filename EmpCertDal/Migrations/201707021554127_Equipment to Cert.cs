namespace EmpCertDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EquipmenttoCert : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeCertifications", "EquipmentId", c => c.Int(nullable: false));
            AddColumn("dbo.Equipments", "Description", c => c.String(maxLength: 50));
            AddColumn("dbo.Equipments", "EmployeeCertification_Id", c => c.Int());
            CreateIndex("dbo.Equipments", "EmployeeCertification_Id");
            AddForeignKey("dbo.Equipments", "EmployeeCertification_Id", "dbo.EmployeeCertifications", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Equipments", "EmployeeCertification_Id", "dbo.EmployeeCertifications");
            DropIndex("dbo.Equipments", new[] { "EmployeeCertification_Id" });
            DropColumn("dbo.Equipments", "EmployeeCertification_Id");
            DropColumn("dbo.Equipments", "Description");
            DropColumn("dbo.EmployeeCertifications", "EquipmentId");
        }
    }
}
