namespace EmpCertDal.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class bob : DbMigration
    {
        public override void Down()
        {
            this.DropTable("dbo.Equipments");
            this.DropTable("dbo.Employees");
            this.DropTable("dbo.Certifications");
        }

        public override void Up()
        {
            this.CreateTable("dbo.Certifications", c => new { Id = c.Int(false, true) }).PrimaryKey(t => t.Id);

            this.CreateTable(
                "dbo.Employees",
                c => new
                         {
                             Id = c.Int(false, true),
                             FirstName = c.String(),
                             LastName = c.String(),
                             PhoneNumber = c.String()
                         }).PrimaryKey(t => t.Id);

            this.CreateTable("dbo.Equipments", c => new { Id = c.Int(false, true) }).PrimaryKey(t => t.Id);
        }
    }
}