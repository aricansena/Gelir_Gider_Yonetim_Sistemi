using Gelir_Gider_Yonetim_Sistemi.Models.GelirGiderVeri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gelir_Gider_Yonetim_Sistemi.Models;
namespace Gelir_Gider_Yonetim_Sistemi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var bugun = DateTime.Today;
            var ayinIlkGunu = new DateTime(bugun.Year, bugun.Month, 1); 
            var ayinSonrakiIlkGunu = ayinIlkGunu.AddMonths(1);
            var yilBaslangici = new DateTime(bugun.Year, 1, 1); 
            var yilSonu = yilBaslangici.AddYears(1);

            var gelirTutarlariToplami = Gelir_Gider_Yonetim_Sistemi.Models.GelirGiderVeri.KayitGelirGider.KayitList
                .Where(k => k.KayitTur == "Gelir")
                .Sum(k => k.Tutar);

            var giderTutarlariToplami = Gelir_Gider_Yonetim_Sistemi.Models.GelirGiderVeri.KayitGelirGider.KayitList
                .Where(k => k.KayitTur == "Gider")
                .Sum(k => k.Tutar);


            var gunlukGelirTutarlariToplami = Gelir_Gider_Yonetim_Sistemi.Models.GelirGiderVeri.KayitGelirGider.KayitList
                .Where(k => k.KayitTur == "Gelir" && k.KayitTarih.Date == bugun)
                .Sum(k => k.Tutar);

            var gunlukGiderTutarlariToplami = Gelir_Gider_Yonetim_Sistemi.Models.GelirGiderVeri.KayitGelirGider.KayitList
                .Where(k => k.KayitTur == "Gider" && k.KayitTarih.Date == bugun)
                .Sum(k => k.Tutar);

            var aylikGelirTutarlariToplami = Gelir_Gider_Yonetim_Sistemi.Models.GelirGiderVeri.KayitGelirGider.KayitList.Where(k => k.KayitTur == "Gelir" && k.KayitTarih >= ayinIlkGunu && k.KayitTarih < ayinSonrakiIlkGunu)
    .Sum(k => k.Tutar);

            var aylikGiderTutarlariToplami = Gelir_Gider_Yonetim_Sistemi.Models.GelirGiderVeri.KayitGelirGider.KayitList
   .Where(k => k.KayitTur == "Gider" && k.KayitTarih >= ayinIlkGunu && k.KayitTarih < ayinSonrakiIlkGunu)
   .Sum(k => k.Tutar);

            var yillikGelirTutarlariToplami = Gelir_Gider_Yonetim_Sistemi.Models.GelirGiderVeri.KayitGelirGider.KayitList
    .Where(k => k.KayitTur == "Gelir" && k.KayitTarih >= yilBaslangici && k.KayitTarih < yilSonu)
    .Sum(k => k.Tutar);
            var yillikGiderTutarlariToplami = Gelir_Gider_Yonetim_Sistemi.Models.GelirGiderVeri.KayitGelirGider.KayitList
    .Where(k => k.KayitTur == "Gider" && k.KayitTarih >= yilBaslangici && k.KayitTarih < yilSonu)
    .Sum(k => k.Tutar);

            ViewBag.YillikGelirTutarlariToplami = yillikGelirTutarlariToplami;
            ViewBag.YillikGiderTutarlariToplami = yillikGiderTutarlariToplami;

            ViewBag.AylikGelirTutarlariToplami = aylikGelirTutarlariToplami;
            ViewBag.AylikGiderTutarlariToplami = aylikGiderTutarlariToplami;

            ViewBag.GunlukGelirTutarlariToplami = gunlukGelirTutarlariToplami;
            ViewBag.GunlukGiderTutarlariToplami = gunlukGiderTutarlariToplami;

            ViewBag.GelirTutarlariToplami = gelirTutarlariToplami;
            ViewBag.GiderTutarlariToplami = giderTutarlariToplami;
            return View();
        }
    }
}