namespace EmpCertDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CertEquipmentfix : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.EmployeeCertifications", "EquipmentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmployeeCertifications", "EquipmentId", c => c.Int(nullable: false));
        }
    }
}
