namespace EmpCertDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExpireDateCertadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Certifications", "CertRenewalTime", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.Employees", "Birth Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Birth Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Certifications", "CertRenewalTime");
        }
    }
}
