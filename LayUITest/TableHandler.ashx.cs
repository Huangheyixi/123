using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace LayUITest
{
	/// <summary>
	/// TableHandler 的摘要说明
	/// </summary>
	public class TableHandler : IHttpHandler
	{
		private JavaScriptSerializer js;
		public TableHandler()
		{
			js = new JavaScriptSerializer();
		}

		public void ProcessRequest(HttpContext context)
		{
			string action = context.Request["action"];
			switch (action)
			{
				case "table1":
					Table(context);
					break;
			}

			//context.Response.ContentType = "text/plain";
			//context.Response.Write("Hello World");
		}

		private void Table(HttpContext context)
		{
			List<dynamic> list = new List<dynamic>();
			list.Add(new { Id = 1, Name = "Name1", Age = 13, Description = "我是备注1" });
			list.Add(new { Id = 2, Name = "Name2", Age = 14, Description = "我是备注2" });
			list.Add(new { Id = 3, Description = "我是备注3" });

			context.Response.ContentType = "application/json";
			context.Response.Write(js.Serialize(new PageData()
			{
				code = 0,
				count = list.Count,
				data = list
			}));
		}

		public bool IsReusable
		{
			get
			{
				return false;
			}
		}
	}
}