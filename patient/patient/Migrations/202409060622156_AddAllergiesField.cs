namespace patient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAllergiesField : DbMigration
    {
        public override void Up()
        {

            //dColumn("dbo.Patients", "Allergies", c => c.String(nullable: false));
        }

        public override void Down()
        {
            //DropColumn("dbo.Patients", "Allergies");
        }
    }
}
