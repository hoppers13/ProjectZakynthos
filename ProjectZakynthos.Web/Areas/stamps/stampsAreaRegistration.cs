using System.Web.Mvc;

namespace ProjectZakynthos.Web.Areas.stamps
{
    public class stampsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "stamps";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "stamps_default",
                "stamps/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}