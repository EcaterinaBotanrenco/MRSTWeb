using System;
using System.Web;
using System.Web.Mvc;
using WebApplication1.BusinessLogic;
using WebApplication1.BusinessLogic.Interfaces;
using WebApplication1.Domain.Entities.User;
using WebApplication1.Web.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISession _session;
        public LoginController()
        {
            var bl = new BussinesLogic();
            _session = bl.GetSessionBL();
        }
        public ActionResult Login()
        {
            return View("Login");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserLogin login)
        {
            if (ModelState.IsValid)
            {
                ULoginData data = new ULoginData
                {
                    Credential = login.Credential,
                    Password = login.Password,
                    LoginIp = Request.UserHostAddress,
                    LoginDateTime = DateTime.Now
                };

                var userLogin = _session.UserLogin(data);
                if (userLogin.Status)
                {
                    HttpCookie cookie = _session.GenCookie(login.Credential);
                    ControllerContext.HttpContext.Response.Cookies.Add(cookie);
                    
                    ModelState.AddModelError("", userLogin.StatusMsg);
                    
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", userLogin.StatusMsg);
                    return View("Login");
                }
            }
            
            return View("Login");
        }
    }
}