namespace patient.Migrations
{
    using PatientInformationSystem.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PatientInformationSystem.Models.PatientDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        /*
        protected override void Seed(PatientInformationSystem.Models.PatientDBContext context)
        {
            context.MaritalStatusOptions.AddOrUpdate(
                m => m.Status,
                new MaritalStatusOption { Status = "Single" },
                new MaritalStatusOption { Status = "Married" },
                new MaritalStatusOption { Status = "Divorced" }
            );
        }
        */
    }
}
