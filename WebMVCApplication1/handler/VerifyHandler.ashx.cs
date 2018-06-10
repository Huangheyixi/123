using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace WebMVCApplication1.handler
{
	/// <summary>
	/// VerifyHandler 的摘要说明
	/// </summary>
	public class VerifyHandler : IHttpHandler
	{

		public void ProcessRequest(HttpContext context)
		{
			context.Response.ContentType = "application/json";
			context.Response.Write(new JavaScriptSerializer().Serialize(new { state = "error" }));
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