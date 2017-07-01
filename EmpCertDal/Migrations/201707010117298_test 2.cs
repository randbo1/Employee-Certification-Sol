namespace EmpCertDal.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class test2 : DbMigration
    {
        public override void Down()
        {
            this.DropColumn("dbo.Certifications", "Location");
            this.DropColumn("dbo.Certifications", "VenderName");
            this.DropColumn("dbo.Certifications", "LeadDays");
        }

        public override void Up()
        {
            this.AddColumn("dbo.Certifications", "LeadDays", c => c.Int(false));
            this.AddColumn("dbo.Certifications", "VenderName", c => c.String());
            this.AddColumn("dbo.Certifications", "Location", c => c.String());
        }
    }
}