using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrandNewDayRescatesMvc.Models
{
    public class Heroe
    {
        [Key]
        public int HeroeId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Alias { get; set; }

        public virtual ICollection<Rescate> Rescates { get; set; }
    }
}