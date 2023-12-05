using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patient_Information_Protal_Backend_Web_Api.Models.DBEntity
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [ForeignKey("DiseaseInformation")]
        public int? DiseaseInformationId { get; set; }
        public DiseaseInformation? DiseaseInformation { get; set; }
        public bool Epilepsy { get; set; }

        public ICollection<NCD_Details>? NCD_Details { get; set; }
        public ICollection<Allergies_Details>? Allergies_Details { get; set; }
    }
}
