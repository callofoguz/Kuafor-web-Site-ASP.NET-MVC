using Deneme09.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deneme09.Controllers
{
    public class RandevuController : Controller
    {
        // GET: Randevu
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Randevus.ToList();
            return View(deger);
        }
        //public ActionResult Index(Randevu x)
        //{
        //    int id = x.id;
        //    int telefon = x.telefon;
        //    string yapılacakIslem = x.yapılacakIslem;
        //    DateTime tarih = x.tarih;
        //    string saat = x.saat;

        //    return View();
            
        
    }
}