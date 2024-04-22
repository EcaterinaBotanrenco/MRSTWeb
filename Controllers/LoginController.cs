using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebApplication1.Domain.Entities.User;
using WebApplication1.Domain.Entities.User.Global;
using WebApplication1.BusinessLogic;
using WebApplication1.BusinessLogic.Interfaces;
using System.ServiceModel.Channels;

namespace WebApplication1.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly WebApplication1.BusinessLogic.Interfaces.ISession _session;
        public LoginController ()
        {
            var bl = new BussinesLogic();
            _session= bl.GetSessionBL();
        }
        // GET : Login
        public ActionResult Index()
        {
            return View("~/Views/Auth/Login.cshtml");

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserLoginAction(ULoginData login)
        {
            if (ModelState.IsValid) 
            { ULoginData data = new ULoginData
                {
                    Credential= login.Credential ,
                    Password = login.Password ,
                    LoginIp = Request.UserHostAddress,
                    LoginDateTime= DateTime.Now
                };
                var userLogin=_session.UserLogin(data);
                if (userLogin.Status) 
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Appointment", "Home");

                }

            }
            return View();
        }
    }
}