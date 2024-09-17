namespace patient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateToPatients : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "Date");
        }
    }
}
