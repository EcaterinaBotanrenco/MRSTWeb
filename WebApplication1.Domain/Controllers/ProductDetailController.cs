using System;
using WebApplication1.Domain.Controllers;
using WebApplication1.Domain.Entities.Product;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace WebApplication1.Domain.Controllers
{
   /* public class ProductDetailController : Controller
    {
        private IProduct _product;
        // GET ProductDetail
        ProductDetailController()
        {
            BussinesLogic bussinesl = new BussinesLogic();
            _product = bussinesl.GetProductBL();
        }
        public ActionResult Index ()
        {
            return View ();
        }
        [HttpPost]
        public ActionResult GetDetailProduct(int id)
        {
            ProductDetail prodDetail= _product.GetDetailProduct(id);
            return View();
        }
    }*/
}
