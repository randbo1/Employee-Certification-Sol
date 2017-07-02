namespace EmpCertDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VSbugTimeSpanNotSupported : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipments", "WarrantyPeriodDays", c => c.Int(nullable: false));
            DropColumn("dbo.Equipments", "WarrantyPeriod");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Equipments", "WarrantyPeriod", c => c.Time(nullable: false, precision: 7));
            DropColumn("dbo.Equipments", "WarrantyPeriodDays");
        }
    }
}
