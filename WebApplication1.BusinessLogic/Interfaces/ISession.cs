using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Domain.Entities.Res;
using WebApplication1.Domain.Entities.User;
using WebApplication1.Domain.Entities.User.Global;

namespace WebApplication1.BusinessLogic.Interfaces
{
    public interface ISession
    {
        ULoginResp UserLogin(ULoginData data);
        
    }

}
