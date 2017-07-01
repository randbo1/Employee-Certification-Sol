namespace EmpCertDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedBirthdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Birth Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Birth Date");
        }
    }
}
