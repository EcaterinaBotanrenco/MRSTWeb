using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebApplication1.BusinessLogic.Interfaces;
using WebApplication1.Domain.Entities.Enums;
using WebApplication1.Web.Extension;

namespace WebApplication1.Web
{
    public class AdminModAttribute : ActionFilterAttribute
    {
        private readonly ISession _sessionBusinessLogic;

        public AdminModAttribute()
        {
            var businessLogic = new BusinessLogic.BussinesLogic();
            _sessionBusinessLogic = businessLogic.GetSessionBL();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var apiCookie = HttpContext.Current.Request.Cookies["X-KEY"];
            if (apiCookie != null)
            {
                var profile = _sessionBusinessLogic.GetUserByCookie(apiCookie.Value);
                if (profile != null && profile.Level == URole.Admin)
                {
                    HttpContext.Current.SetMySessionObject(profile);
                }
                else
                {
                    filterContext.Result = new RedirectToRouteResult(new
                        RouteValueDictionary(new { controller = "Error", action = "Error404" }));
                }
            }
        }
    }
}