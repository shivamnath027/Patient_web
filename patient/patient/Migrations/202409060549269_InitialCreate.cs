namespace patient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Patients",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    Gender = c.String(nullable: false),
                    Address = c.String(nullable: false),
                    BloodGroup = c.String(nullable: false),
                    EmailAddress = c.String(nullable: false),
                    PhoneNumber = c.String(nullable: false),
                    DoctorReferred = c.String(nullable: false),
                    Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                    BMI = c.Decimal(nullable: false, precision: 18, scale: 2),
                    MaritalStatus = c.String(nullable: false),
                    Allergies = c.String(nullable: false),
        })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Patients");
        }
    }
}
