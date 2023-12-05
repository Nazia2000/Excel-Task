﻿using System.ComponentModel.DataAnnotations;

namespace Patient_Information_Protal_Backend_Web_Api.Models.DBEntity
{
    public class Allergies
    {
        [Key]
        public int Id { get; set; }
        public string AllergyName { get; set; } = string.Empty;
    }
}
