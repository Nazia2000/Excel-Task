using System.ComponentModel.DataAnnotations;

namespace Patient_Information_Protal_Backend_Web_Api.Models.DBEntity
{
    public class DiseaseInformation
    {
        [Key]
        public int Id { get; set; }
        public string DiseaseName { get; set; } = string.Empty;
    }
}
