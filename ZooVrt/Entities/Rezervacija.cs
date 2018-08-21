using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ZooVrt.Entities
{
    [Table("Rezervacija")]
    public class Rezervacija
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int rezervacijaID { get; set; }
        [MaxLength(30)]
        [Required]
        public string korisnickoIme { get; set; }
        [Required]
        public int dogadjaj { get; set; }
        [Required]
        public int termin { get; set; }
        [Required]
        public int brRezervisanihKarata { get; set; }
    }
}