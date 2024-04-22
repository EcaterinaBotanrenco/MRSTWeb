using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Domain.Entities.User;
using WebApplication1.Domain.Entities.Res;
using WebApplication1.Domain.Entities.User.Global;
using WebApplication1.BusinessLogic.DBModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using WebApplication1.Helpers;

namespace WebApplication1.BusinessLogic.Core
{
    public class UserApi
    {
        public bool UserSessionStatus()
        {
            return true;
        }
        internal ULoginResp UserSessionData(ULoginData data)
        {
            UDbTable result;
            using (var db = new UserContext())
            {
                result = db.Users.FirstOrDefault(u => u.Username == data.Credential && u.Password == data.Password);
            }
            if (result == null)
            {
                return new ULoginResp
                {
                    Status = false,
                    StatusMsg = "The username or password is incorrect!"
                };
            }
            return new ULoginResp { Status = true };
        }
        internal ULoginResp UserLoginAction(ULoginData data)
        {
            UDbTable result;
            var validate = new EmailAddressAttribute();
            if (validate.IsValid(data.Credential))
            {
                var pass = LoginHelper.HashGen(data.Password);
                using (var db = new UserContext())
                {
                    result = db.Users.FirstOrDefault(u => u.Email == data.Credential && u.Password == pass);
                }

                if (result == null)
                {
                    return new ULoginResp { Status = false, StatusMsg = "The Username or Password is Incorrect" };
                }

                using (var todo = new UserContext())
                {
                    result.LasIp = data.LoginIp;
                    result.LastLogin = data.LoginDateTime;
                    todo.Entry(result).State = EntityState.Modified;
                    todo.SaveChanges();
                }

                return new ULoginResp { Status = true };
            }
            else
            {
                var pass = LoginHelper.HashGen(data.Password);
                using (var db = new UserContext())
                {
                    result = db.Users.FirstOrDefault(u => u.Username == data.Credential && u.Password == pass);
                }

                if (result == null)
                {
                    return new ULoginResp { Status = false, StatusMsg = "The Username or Password is Incorrect" };
                }

                using (var todo = new UserContext())
                {
                    result.LasIp = data.LoginIp;
                    result.LastLogin = data.LoginDateTime;
                    todo.Entry(result).State = EntityState.Modified;
                    todo.SaveChanges();
                }

                return new ULoginResp { Status = true };
            }
        }


    }

}
