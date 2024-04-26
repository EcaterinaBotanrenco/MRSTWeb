using System.Web;
using WebApplication1.BusinessLogic.Core;
using WebApplication1.BusinessLogic.Interfaces;
using WebApplication1.Domain.Entities.Appointment;
using WebApplication1.Domain.Entities.User;

namespace WebApplication1.BusinessLogic
{
    public class SessionBL : UserApi, ISession
    {
        public ULoginResp UserLogin(ULoginData data)
        {
            return ULoginAction(data);
        }
        public URegisterResp UserRegister(URegisterData data)
        {
            return URegisterAction(data);
        }
        public HttpCookie GenCookie(string loginCredential)
        {
            return Cookie(loginCredential);
        }
        public UserMinimal GetUserByCookie(string apiCookieValue)
        {
            return UserCookie(apiCookieValue);
        }

        public AppointmentListResp AppointmentList(bool isAdmin)
        {
            return AppointmentsListAction(isAdmin);
        }
    }
}
