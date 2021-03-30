 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MVCKutuphane.Models.Entity;
namespace MVCKutuphane.Controllers
{
    public class PanelimController : Controller
    {
        // GET: Panelim
        DBKUTUPHANEEntities db = new DBKUTUPHANEEntities();
       
        [Authorize]
        public ActionResult Index()
        {
            var uyemail = (string)Session["MAIL"];
            var degerler = db.TBLUYELER.FirstOrDefault(z => z.MAIL == uyemail);
            return View(degerler);
        }
        [HttpPost]
        public ActionResult Index2(TBLUYELER p)
        {
            var kullanici = (string)Session["MAIL"];
            var üye = db.TBLUYELER.FirstOrDefault(x=>x.MAIL==kullanici);
            üye.SIFRE = p.SIFRE;
            üye.AD = p.AD;
            üye.SOYAD = p.SOYAD;
            üye.FOTOGRAF = p.FOTOGRAF;
            üye.OKUL = p.OKUL;
            üye.KULLANICI_ADI = p.KULLANICI_ADI;

            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Kitaplarim()
        {
            var kullanici = (string)Session["MAIL"];
            var id = db.TBLUYELER.Where(x => x.MAIL == kullanici.ToString()).Select(z => z.ID).FirstOrDefault();
            var degerler = db.TBLHAREKET.Where(x => x.UYE == id).ToList();
            return View(degerler);
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("GirisYap", "Login");
        }
    }
}