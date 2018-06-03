using MvcAndEasyUI.TestObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAndEasyUI.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public ActionResult Show()
		{
			List<Person> list = new List<Person>();
			list.Add(new Person() { ID = 1, Name = "Json1" });
			list.Add(new Person() { ID = 1, Name = "Json2" });
			list.Add(new Person() { ID = 2, Name = "Json3" });

			List<dynamic> resultList = new List<dynamic>();

			foreach (var p in list.GroupBy(p => p.ID))
			{
				List<dynamic> data=new List<dynamic>();
				foreach (var item in p)
				{
					data.Add(new { Name = item.Name });
				}
				resultList.Add(new { ID = p.Key, data = data });
			}


			return Json(new { state="OK",data=list});
		}
    }

	
}