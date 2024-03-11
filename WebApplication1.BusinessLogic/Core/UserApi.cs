using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Domain.Entities.User;
using WebApplication1.Domain.Entities.Res;
using WebApplication1.Domain.Entities.User.Global;
using WebApplication1.Domain.Entities.Product;

namespace WebApplication1.BusinessLogic.Core
{
    internal class UserApi
    { 
        internal ActionStatus UserLogData (ULoginData data)
        {
            return new ActionStatus();
        }
        internal LevelStatus CheckLevelLogin(string keySession)
        {
            return new LevelStatus ();
        }
        internal ProductDetail GetProdUser (int id)
        {
            return new ProductDetail();
        }
    }

}
