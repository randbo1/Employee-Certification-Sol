namespace EmpCertDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class certrenualtimespantodaysvsbug : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Certifications", "CertRenewalDays", c => c.Int(nullable: false));
            DropColumn("dbo.Certifications", "CertRenewalTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Certifications", "CertRenewalTime", c => c.Time(nullable: false, precision: 7));
            DropColumn("dbo.Certifications", "CertRenewalDays");
        }
    }
}
