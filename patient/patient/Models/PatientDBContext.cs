using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PatientInformationSystem.Models
{
    public class PatientDBContext : DbContext
    {
        public PatientDBContext() : base("name=PatientDBContext")
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<MaritalStatusOption> MaritalStatusOptions { get; set; }
        public List<Patient> GetPatients()
        {
            return this.Database.SqlQuery<Patient>("GetPatients").ToList();
        }
        public DbSet<GenderOption> GenderOptions { get; set; }

    }
}
