using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebApplication1.BusinessLogic;
using WebApplication1.BusinessLogic.Interfaces;
using WebApplication1.Domain.Entities.User;
using WebApplication1.Domain.Entities.User.Global;

namespace WebApplication1.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISession _session;
        public LoginController ()
        {
            var bl = new BussinesLogic();
            _session= bl.GetSessionBL();
        }
        // GET : Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index (ULoginData login)
        {
            if (ModelState.IsValid) 
            { ULoginData data = new ULoginData
                {
                    Credential= login.Credential ,
                    Password = login.Password ,
                    LoginIp = Request.UserHostAddress,
                    LoginDataTime= DateTime.Now
                };
                var userLogin=_session.UserLogin(data);
                if (userLogin.Status) 
                {
                    LevelStatus status = _session.CheckLevel(userLogin.SessionKey);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Nume de utilizator sau parola incorecta . Va rugam sa incercati din nou!",userLogin.StatusMessage);
                    return View();

                }

            }
            return View();
        }
    }
}