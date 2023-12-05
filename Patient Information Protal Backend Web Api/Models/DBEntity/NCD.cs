using System.ComponentModel.DataAnnotations;

namespace Patient_Information_Protal_Backend_Web_Api.Models.DBEntity
{
    public class NCD
    {
        [Key]
        public int Id { get; set; }
        public string NCDName { get; set; } = string.Empty;
    }
}
