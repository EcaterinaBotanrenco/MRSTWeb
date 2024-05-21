using System.Web.Mvc;
using WebApplication1.Web.Controllers;
using WebApplication1.Web.Extension;
using WebApplication1.Web.Models;

namespace WebApplication1.Controllers
{
    public class HomeController  : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Login", "Login");
            }
            
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            UserData u = new UserData
            {
                Username = user.Username,
                Level = user.Level,
            };

            ViewBag.username = u.Username;
            ViewBag.userLevel = u.Level;

            return View();

        }
        public ActionResult About()
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Login", "Login");
            }
            
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            UserData u = new UserData
            {
                Username = user.Username,
                Level = user.Level,
            };

            ViewBag.username = u.Username;
            ViewBag.userLevel = u.Level;

            return View();
        }
        public ActionResult Service()
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Login", "Login");
            }
            
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            UserData u = new UserData
            {
                Username = user.Username,
                Level = user.Level,
            };

            ViewBag.username = u.Username;
            ViewBag.userLevel = u.Level;

            return View();
        }
        public ActionResult Price()
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Login", "Login");
            }
            
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            UserData u = new UserData
            {
                Username = user.Username,
                Level = user.Level,
            };

            ViewBag.username = u.Username;
            ViewBag.userLevel = u.Level;

            return View();
        }

        public ActionResult Appointment()
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Login", "Login");
            }
            
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            UserData u = new UserData
            {
                Username = user.Username,
                Level = user.Level,
            };

            ViewBag.username = u.Username;
            ViewBag.userLevel = u.Level;

            return View();
        }
        public ActionResult Test()
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Login", "Login");
            }
            
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            UserData u = new UserData
            {
                Username = user.Username,
                Level = user.Level,
            };

            ViewBag.username = u.Username;
            ViewBag.userLevel = u.Level;

            return View();
        }
        public ActionResult OpenHours()
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Login", "Login");
            }
            
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            UserData u = new UserData
            {
                Username = user.Username,
                Level = user.Level,
            };

            ViewBag.username = u.Username;
            ViewBag.userLevel = u.Level;

            return View();
        }
        public ActionResult OurTeam()
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Login", "Login");
            }
            
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            UserData u = new UserData
            {
                Username = user.Username,
                Level = user.Level,
            };

            ViewBag.username = u.Username;
            ViewBag.userLevel = u.Level;

            return View();
        }
        public ActionResult Testimonial()
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Login", "Login");
            }
            
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            UserData u = new UserData
            {
                Username = user.Username,
                Level = user.Level,
            };

            ViewBag.username = u.Username;
            ViewBag.userLevel = u.Level;

            return View();
        }
        public ActionResult Contact()
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return RedirectToAction("Login", "Login");
            }
            
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            UserData u = new UserData
            {
                Username = user.Username,
                Level = user.Level,
            };

            ViewBag.username = u.Username;
            ViewBag.userLevel = u.Level;

            return View(); 
        }



    }
}