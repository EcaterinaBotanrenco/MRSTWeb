using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Domain.Entities.Appointment;
using WebApplication1.Domain.Entities.User;

namespace WebApplication1.BusinessLogic.DBModel
{
    public class AppointmentContext : DbContext
    {
        public void FixEfProviderServicesProblem()
        {
            //The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            //for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            //Make sure the provider assembly is available to the running application. 
            //See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.

            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public AppointmentContext() : base("name = WebApplication1")
        {
        }

        public virtual DbSet<ADbTable> Appointments { get; set; }
    }
}