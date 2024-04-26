using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Domain.Entities.Appointment
{
    public class AppointmentListResp
    {
        public List<AppointmentListData> Appointments { get; set; }
        public bool Status { get; set; }
        public string StatusMsg { get; set; }
    }
}
