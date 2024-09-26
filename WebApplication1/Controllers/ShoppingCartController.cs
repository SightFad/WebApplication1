using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart tính tiền dựa trên số lượng và đơn giá
        public ActionResult ShoppingCart()
        {
            return View();
        }
    }
}