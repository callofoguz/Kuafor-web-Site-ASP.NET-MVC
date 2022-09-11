using Deneme09.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Deneme09.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: AdminLogin
        Context c = new Context();
        
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(Admin ad)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.kullaniciadi == ad.kullaniciadi && x.sifre == ad.sifre);
            if(bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.kullaniciadi, false);
                Session["kullaniciadi"] = bilgiler.kullaniciadi.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("AdminLogin", "AdminLogin");
        }
        
    }

}