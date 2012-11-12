using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace CodeCamp2012LiveAgain.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var help = GlobalConfiguration.Configuration.Services.GetApiExplorer();
            return View(help);

        }
    }
}
