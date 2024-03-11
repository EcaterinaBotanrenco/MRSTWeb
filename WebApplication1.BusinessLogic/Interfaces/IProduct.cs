using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Domain.Entities.Product;

namespace WebApplication1.BusinessLogic.Interfaces
{
    public interface IProduct
    {
        ProductDetail GetDetailProduct(int id);
    }
}
