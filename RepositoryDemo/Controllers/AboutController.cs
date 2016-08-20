using RepositoryDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepositoryDemo.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /Default1/
        public ActionResult Index()
        {
            //ViewBag.Location = "Sydney";
            AboutModel am = new AboutModel();
            am.Location = "Sydney";
            return View(am);
        }
	}
}