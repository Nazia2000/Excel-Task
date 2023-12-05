using Microsoft.EntityFrameworkCore;
using Patient_Information_Protal_Backend_Web_Api.Models.DBEntity;
using System.Collections.Generic;


namespace Patient_Information_Protal_Backend_Web_Api.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<DiseaseInformation> DiseaseInformations { get; set; }
        public DbSet<NCD> NCDs { get; set; }
        public DbSet<Allergies> Allergies { get; set; }
        public DbSet<NCD_Details> NCD_Details { get; set; }
        public DbSet<Allergies_Details> Allergies_Details { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
