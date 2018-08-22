using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace ZooVrt.Areas.Korisnik.Models
{
    public class SmallButtonModel
    {
        public string Action { get; set; }
        public string Text { get; set; }
        public string Glyph { get; set; }
        public string ButtonType { get; set; }
        public int? rezervacijaId { get; set; }

        public string ActionParameters
        {
            get
            {
                var param = new StringBuilder("?");

                if (rezervacijaId != null && rezervacijaId > 0)
                    param.Append(String.Format("{0}={1}&", "id", rezervacijaId));

                return param.ToString().Substring(0, param.Length - 1);
            }
        }


    }
}