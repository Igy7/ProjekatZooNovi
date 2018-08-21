using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ZooVrt.Entities
{
    [Table("Termin")]
    public class Termin
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int terminID { get; set; }
        [MaxLength(30)]
        [Required]
        public string vremePocetka { get; set; }
        [MaxLength(30)]
        [Required]
        public string vremeKraja { get; set; }
        [Required]
        public int brKarata { get; set; }
    }

}