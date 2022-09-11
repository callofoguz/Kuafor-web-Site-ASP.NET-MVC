using Deneme09.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deneme09.Controllers
{
    public class HizmetlerController : Controller
    {
        // GET: Hizmetler
        Context c = new Context();
        public ActionResult hizmetler()
        {
            var deger = c.Hizmetlers.ToList();
            return View(deger);
        }

       
    }
}