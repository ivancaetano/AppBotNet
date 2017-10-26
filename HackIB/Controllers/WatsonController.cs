using HackIB.Controllers.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HackIB.Controllers
{
    public class WatsonController : Controller
    {
        //
        // GET: /Watson/
        public ActionResult Conversa(string texto)
        {
            return Json(Watson.Conversa(texto), JsonRequestBehavior.AllowGet);
        }
	}
}