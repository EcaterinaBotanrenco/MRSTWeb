using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.BusinessLogic.Core;
using WebApplication1.Domain.Entities.Product;

namespace WebApplication1.BusinessLogic
{
     class ProductBL : UserApi, IProduct
    {
        public ProductDetail GetDetailProduct (int id)
        {
            return GetProdUser (id);
        }
    }
}
