namespace patient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class UpdateDatabaseSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GenderOptions",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Gender = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Gender, unique: true); // Add unique index
        }

        public override void Down()
        {
            DropIndex("dbo.GenderOptions", new[] { "Gender" }); // Remove unique index
            DropTable("dbo.GenderOptions");
        }
    }
}
