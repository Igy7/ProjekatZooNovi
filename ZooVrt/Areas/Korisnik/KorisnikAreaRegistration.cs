using System.Web.Mvc;

namespace ZooVrt.Areas.Korisnik
{
    public class KorisnikAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Korisnik";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Korisnik_default",
                "Korisnik/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}