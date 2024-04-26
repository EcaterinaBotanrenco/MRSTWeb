using System.Web;
using WebApplication1.Domain.Entities.Appointment;
using WebApplication1.Domain.Entities.User;

namespace WebApplication1.BusinessLogic.Interfaces
{
    public interface ISession
    {
        ULoginResp UserLogin(ULoginData data);
        URegisterResp UserRegister(URegisterData data);
        AppointmentListResp AppointmentList(bool isAdmin);
        HttpCookie GenCookie(string loginCredential);
        UserMinimal GetUserByCookie(string apiCookieValue);
    }

}
