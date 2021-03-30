using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCKutuphane.Models.Entity;
using System.Web.Security; 
namespace MVCKutuphane.Controllers
{
    public class LoginController : Controller
    {
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
        public ActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GirisYap(TBLUYELER p)
        {
            var bilgiler = db.TBLUYELER.FirstOrDefault(x => x.MAIL == p.MAIL && x.SIFRE == p.SIFRE);
            if(bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.MAIL, false);
                Session["MAIL"] = bilgiler.MAIL.ToString(); 
                //TempData["AD"] = bilgiler.AD.ToString();
                //TempData["SOYAD"] = bilgiler.SOYAD.ToString();
                //TempData["KULLANICIADI"] = bilgiler.KULLANICI_ADI.ToString();
                //TempData["SIFRE"] = bilgiler.SIFRE.ToString();
                //TempData["OKUL"] = bilgiler.OKUL.ToString();
                //TempData["ID"] = bilgiler.ID.ToString();
                return RedirectToAction("Index", "Panelim");
                    }
            else
            {
                return View();
            }

            
        }
    }
}