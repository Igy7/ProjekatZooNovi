using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ZooVrt.Entities
{
    [Table("Korisnik")]
    public class Korisnik
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int korisnikId { get; set; }
        [MaxLength(30)]
        [Required]
        public string korisnickoIme { get; set; }
        [MaxLength(30)]
        [Required]
        public string sifra { get; set; }
        [MaxLength(30)]
        [Required]
        public string ime { get; set; }
        [MaxLength(30)]
        [Required]
        public string prezime { get; set; }
        [MaxLength(10)]
        [Required]
        public string telefon { get; set; }
    }
}