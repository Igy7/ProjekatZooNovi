using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ZooVrt.Entities
{
    [Table("Dogadjaj")]
    public class Dogadjaj
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int dogadjajId { get; set; }
        [MaxLength(30)]
        [Required]
        public string naziv { get; set; }
        [MaxLength(30)]
        [Required]
        public string datum { get; set; }
        [Required]
        public float cenaKarte { get; set; }
    }
}