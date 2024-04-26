using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Domain.Entities.User;
using WebApplication1.BusinessLogic.DBModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Web;
using WebApplication1.Domain.Entities.Appointment;
using WebApplication1.Domain.Entities.Enums;
using WebApplication1.Helpers;

namespace WebApplication1.BusinessLogic.Core
{
    public class AppointmentApi
    {
        internal AppointmentListResp AppointmentsListAction(bool isAdmin)
        {
            List<ADbTable> result;

            using (var db = new AppointmentContext())
            {
                result = isAdmin ? db.Appointments.ToList() : db.Appointments.Where(b => b.UserId == 1).ToList();
            }

            var appointments = new List<AppointmentListData>();

            foreach (var a in result)
            {
                appointments.Add(new AppointmentListData
                {
                    Id = a.Id,
                    UserId = a.UserId,
                    Name = a.Name,
                    Service = a.Service,
                    Email = a.Email,
                    AppointmentDate = a.AppointmentDate
                });
            }
            
            return new AppointmentListResp() { 
                Appointments = appointments,
                Status = true,                     
                StatusMsg = "Success"
            };
        }
    }
}
