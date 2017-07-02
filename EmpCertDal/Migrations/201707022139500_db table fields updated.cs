namespace EmpCertDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbtablefieldsupdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Certifications", "VendorName", c => c.String());
            DropColumn("dbo.Certifications", "VenderName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Certifications", "VenderName", c => c.String());
            DropColumn("dbo.Certifications", "VendorName");
        }
    }
}
