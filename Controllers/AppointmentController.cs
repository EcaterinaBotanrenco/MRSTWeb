using System.Web.Mvc;
using WebApplication1.BusinessLogic;
using WebApplication1.BusinessLogic.Interfaces;
using WebApplication1.Web;
using WebApplication1.Web.Extension;
using WebApplication1.Web.Models;

namespace WebApplication1.Controllers
{
    public class AppointmentController: Controller
    {
        private readonly ISession _session;

        public AppointmentController()
        {
            var bl = new BussinesLogic();
            _session = bl.GetSessionBL();
        }
        public ActionResult AppointmentsList()
        {
            bool isAdmin = false;
            
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            UserData u = new UserData
            {
                Username = user.Username,
            };
            
            var appointmentsList = _session.AppointmentList(isAdmin);
            
            ViewBag.username = u.Username;
            ViewBag.appointmentsList = appointmentsList.Appointments;
            
            return View();
        }
        
        [AdminMod]
        public ActionResult AdminAppointmentsList()
        {
            bool isAdmin = true;
            
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            UserData u = new UserData
            {
                Username = user.Username,
            };
            
            var appointmentsList = _session.AppointmentList(isAdmin);
            
            ViewBag.username = u.Username;
            ViewBag.appointmentsList = appointmentsList.Appointments;
            
            return View();
        }
    }
}