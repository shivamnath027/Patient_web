namespace patient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMaritalStatusOptions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MaritalStatusOptions",
                c => new
                {
                ID = c.Int(nullable: false, identity: true),
                Status = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Status, unique: true);


        }

        public override void Down()
        {
            DropTable("dbo.MaritalStatusOptions");
        }
    }
}
