using System.Web.Mvc;
using WebApplication1.BusinessLogic;
using WebApplication1.BusinessLogic.Interfaces;
using WebApplication1.Domain.Entities.User;
using WebApplication1.Web.Models;

namespace WebApplication1.Web.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ISession _session;
        public RegisterController()
        {
            var bl = new BussinesLogic();
            _session = bl.GetSessionBL();
        }
        public ActionResult Register()
        {
            return View("Register");
        }


        [HttpPost]
        public ActionResult Register(UserRegister register)
        {
            if (ModelState.IsValid)
            {
                URegisterData data = new URegisterData
                {
                    Username = register.Username,
                    Email = register.Email,
                    Password = register.Password,
                    
                };
                var userRegister = _session.UserRegister(data);
                if (userRegister.Status)
                {
                    return RedirectToAction("Login", "Login");
                }
                else
                {
                    ModelState.AddModelError("", userRegister.StatusMsg);
                    return View("Register");
                }
            }
            return View("Register");
        }
    }
}