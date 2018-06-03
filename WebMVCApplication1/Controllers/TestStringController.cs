using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace WebMVCApplication1.Controllers
{
    public class TestStringController : Controller
    {
        // GET: TestString
        public ActionResult Index()
        {
			int intVal = "1".AsInt();
			DateTime time = "2018/1/10".AsDateTime();
			decimal d1 = "1.1".As<decimal>();
            return View();
        }
    }
}