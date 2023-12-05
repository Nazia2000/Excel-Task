using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patient_Information_Protal_Backend_Web_Api.Models.DBEntity
{
    public class Allergies_Details
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Patient")]
        public int PatientID { get; set; }

        [ForeignKey("Allergies")]
        public int AllergiesID { get; set; }
        public Patient? Patient { get; set; }
        public Allergies? Allergies { get; set; }
    }
}
