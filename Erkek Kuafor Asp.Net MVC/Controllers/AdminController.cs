using Deneme09.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deneme09.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.Hizmetlers.ToList();
            return View(deger);
        }

        public ActionResult HizmetlerGetir(int id)
        {
            var hg = c.Hizmetlers.Find(id);
            return View("HizmetlerGetir", hg);
        }
        public ActionResult HizmetlerGuncelle(Hizmetler x)
        {
            var hg = c.Hizmetlers.Find(x.id);
            hg.islem = x.islem;
            hg.islemacıkla = x.islemacıkla;
            hg.fiyat = x.fiyat;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult RandevuGetir()
        {
            var rd = c.Randevus.ToList();
            return View(rd);
        }
    }
}