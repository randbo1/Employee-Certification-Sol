namespace EmpCertDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Certifications", "LeadDays", c => c.Int(nullable: false));
            AddColumn("dbo.Certifications", "VenderName", c => c.String());
            AddColumn("dbo.Certifications", "Location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Certifications", "Location");
            DropColumn("dbo.Certifications", "VenderName");
            DropColumn("dbo.Certifications", "LeadDays");
        }
    }
}
