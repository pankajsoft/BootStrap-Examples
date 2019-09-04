using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootStrapMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        [Route("Home")]
        public ActionResult Index()
        {
            return View();
        }
    }
}