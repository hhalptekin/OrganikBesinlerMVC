using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrganikBesinlerMVC.Models.Entity;

namespace OrganikBesinlerMVC.Controllers
{
    public class DefaultController : Controller
    {
        OrganikBesinlerEntities db = new OrganikBesinlerEntities();
        // GET: Default
        public ActionResult Index()
        {
            var degerler = db.OrganikÜrünler.ToList();
            return View(degerler);
        }
    }
}