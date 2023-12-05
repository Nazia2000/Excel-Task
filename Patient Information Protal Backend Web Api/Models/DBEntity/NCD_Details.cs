using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patient_Information_Protal_Backend_Web_Api.Models.DBEntity
{
    public class NCD_Details
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Patient")]
        public int PatientID { get; set; }

        [ForeignKey("NCD")]
        public int NCDID { get; set; }

        public Patient? Patient { get; set; }
        public NCD? NCD { get; set; }
    }
}
