using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Visuals.Controllers
{
    public class BreezeController : Controller
    {
		[System.Web.Http.HttpGet]
		public JsonResult Posts(string user)
		{
			return Json(new { result = "successful!" });
		}
    }
}
