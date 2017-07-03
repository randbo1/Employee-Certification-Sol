namespace EmpCertDal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class baseclasschanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Certifications", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Certifications", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.EmployeeCertifications", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.EmployeeCertifications", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employees", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employees", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Equipments", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Equipments", "ModifiedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Equipments", "ModifiedDate");
            DropColumn("dbo.Equipments", "CreatedDate");
            DropColumn("dbo.Employees", "ModifiedDate");
            DropColumn("dbo.Employees", "CreatedDate");
            DropColumn("dbo.EmployeeCertifications", "ModifiedDate");
            DropColumn("dbo.EmployeeCertifications", "CreatedDate");
            DropColumn("dbo.Certifications", "ModifiedDate");
            DropColumn("dbo.Certifications", "CreatedDate");
        }
    }
}
