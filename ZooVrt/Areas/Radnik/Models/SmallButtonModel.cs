using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ZooVrt.Areas.Radnik.Models
{
    public class SmallButtonModel
    {
        public string Action { get; set; }
        public string Text { get; set; }
        public string Glyph { get; set; }
        public string ButtonType { get; set; }
        public int? dogadjajId { get; set; }
        public int? terminId { get; set; }
        public int? rezervacijaId { get; set; }
        public string UserId { get; set; }

        public string ActionParameters
        {
            get
            {
                var param = new StringBuilder("?");

                if (dogadjajId != null && dogadjajId > 0)
                    param.Append(String.Format("{0}={1}&", "id", dogadjajId));

                if (terminId != null && terminId > 0)
                    param.Append(String.Format("{0}={1}&", "id", terminId));

                if (rezervacijaId != null && rezervacijaId > 0)
                    param.Append(String.Format("{0}={1}&", "id", rezervacijaId));

                if(UserId != null && !UserId.Equals(string.Empty))
                    param.Append(String.Format("{0}={1}&", "userId", UserId));
                return param.ToString().Substring(0, param.Length - 1);
            }
        }
    }
}