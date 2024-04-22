using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.BusinessLogic.Core;
using WebApplication1.BusinessLogic.Interfaces;
using WebApplication1.Domain.Entities.Res;
using WebApplication1.Domain.Entities.User;
using WebApplication1.Domain.Entities.User.Global;

namespace WebApplication1.BusinessLogic
{
    public class SessionBL : UserApi, ISession
    {
        public ULoginResp UserLogin(ULoginData data)
        {
            return UserLoginAction(data);
        }
        /* public LevelStatus CheckLevel (string key)
         {
             return CheckLevelLogin(key);
         }*/
    }
}
