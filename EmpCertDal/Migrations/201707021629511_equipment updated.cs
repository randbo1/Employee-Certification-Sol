namespace EmpCertDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class equipmentupdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipments", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Equipments", "WarrantyPeriod", c => c.Time(nullable: false, precision: 7));
            AddColumn("dbo.Equipments", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Equipments", "Status");
            DropColumn("dbo.Equipments", "WarrantyPeriod");
            DropColumn("dbo.Equipments", "PurchaseDate");
        }
    }
}
