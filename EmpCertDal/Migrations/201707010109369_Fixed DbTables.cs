namespace EmpCertDal.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class FixedDbTables : DbMigration
    {
        public override void Down()
        {
            this.AddColumn("dbo.Certifications", "Employee_Id", c => c.Int());
            this.CreateIndex("dbo.Certifications", "Employee_Id");
            this.AddForeignKey("dbo.Certifications", "Employee_Id", "dbo.Employees", "Id");
        }

        public override void Up()
        {
            this.DropForeignKey("dbo.Certifications", "Employee_Id", "dbo.Employees");
            this.DropIndex("dbo.Certifications", new[] { "Employee_Id" });
            this.DropColumn("dbo.Certifications", "Employee_Id");
        }
    }
}