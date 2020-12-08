using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Item
    {
        [Required]
        public string moeda { get; set; }

        public DateTime data_inicio { get; set; }
        public DateTime data_fim { get; set; }
    }
}
