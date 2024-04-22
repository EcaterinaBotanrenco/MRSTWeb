using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.BusinessLogic.Interfaces;

namespace WebApplication1.BusinessLogic
{
    public class BussinesLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }
       /* public IProduct GetProductBL()
        {
            return new ProductBL();
        }*/
    }
}
