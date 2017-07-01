namespace EmpCertDal.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class fixedBirthdate : DbMigration
    {
        public override void Down()
        {
            this.DropColumn("dbo.Employees", "Birth Date");
        }

        public override void Up()
        {
            this.AddColumn("dbo.Employees", "Birth Date", c => c.DateTime(false));
        }
    }
}