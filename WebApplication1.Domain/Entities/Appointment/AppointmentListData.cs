using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Domain.Entities.Appointment
{
    public class AppointmentListData
    {
        public int Id { get; set; }
        
        public int UserId { get; set; }
        
        public string Name { get; set; }
        
        public string Service { get; set; }
        
        public string Email { get; set; }
        
        public Nullable<DateTime> AppointmentDate { get; set; }
    }
}
