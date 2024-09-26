using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: Trang welcome viết dưới dạng JS inline,
        //sử dụng hộp thoại Prompt để nhập liệu
        //câu lệnh document để hiển thị dữ liệu
        public ActionResult Welcome()
        {
            return View();
        }

        // GET: Trang welcome viết dưới dạng JS inline,
        //sử dụng hộp thoại Prompt để nhập liệu
        //câu lệnh document để hiển thị dữ liệu
        public ActionResult Welcome2()
        {
            return View();
        }
        public ActionResult Welcome3()
        {
            return View();
        }
    }
}