using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Gelir_Gider_Yonetim_Sistemi.Models.GelirGiderVeri;
namespace Gelir_Gider_Yonetim_Sistemi.Controllers
{
    public class RaporController : Controller
    {
        public ActionResult GelirGiderRaporu()
        {
          
            return View(new List<Models.KayitGelirGider>());
        }

        [HttpPost]
        public ActionResult GelirGiderRaporu(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            var filtreliKayitlar = KayitGelirGider.KayitList
                .Where(k => k.KayitTarih >= baslangicTarihi && k.KayitTarih <= bitisTarihi)
                .ToList();

            if (!filtreliKayitlar.Any())
            {
                TempData["NoDataMessage"] = "Kayıt bulunamadı.";
                return RedirectToAction("GelirGiderRaporu");
            }
            TempData["baslangicTarih"] = baslangicTarihi;
            TempData["bitisTarih"] = bitisTarihi;

            TempData["FilteredRecords"] = filtreliKayitlar;
            return RedirectToAction("Rapor");
        }

        public ActionResult Rapor()
        {
            var filtreliKayitlar = TempData["FilteredRecords"] as List<Models.KayitGelirGider>;

            if (filtreliKayitlar == null || !filtreliKayitlar.Any())
            {
                ViewBag.NoDataMessage = "Filtrelenmiş kayıt bulunamadı.";
            }
            else
            {
     
                var gelirTutarlariToplami = filtreliKayitlar
                    .Where(k => k.KayitTur == "Gelir")
                    .Sum(k => k.Tutar);

                ViewBag.GelirTutarlariToplami = gelirTutarlariToplami;
             
                var giderTutarlariToplami = filtreliKayitlar
                    .Where(k => k.KayitTur == "Gider")
                    .Sum(k => k.Tutar);

                var baslangicTarihi = TempData["baslangicTarih"] as DateTime?;
                var bitisTarihi = TempData["bitisTarih"] as DateTime?;

                if (baslangicTarihi.HasValue && bitisTarihi.HasValue)
                {
                    ViewBag.baslangicTarih = baslangicTarihi.Value.ToString("dd.MM.yyyy");
                    ViewBag.bitisTarih = bitisTarihi.Value.ToString("dd.MM.yyyy");
                }
                ViewBag.GiderTutarlariToplami = giderTutarlariToplami;

                var netBakiye = gelirTutarlariToplami - giderTutarlariToplami;
                ViewBag.NetBakiye = netBakiye;
                 
                var tariheGoreGelirTutarlariToplami = filtreliKayitlar
                    .Where(k => k.KayitTur == "Gelir" && k.KayitTarih>baslangicTarihi && k.KayitTarih<bitisTarihi)
                    .Sum(k => k.Tutar);

                @ViewBag.TariheGoreGelirTutarlariToplami = tariheGoreGelirTutarlariToplami;

                var tariheGoreGiderTutarlariToplami=filtreliKayitlar
                    .Where(k => k.KayitTur == "Gider" && k.KayitTarih > baslangicTarihi && k.KayitTarih < bitisTarihi)
                    .Sum(k => k.Tutar); @ViewBag.TariheGoreGiderTutarlariToplami = tariheGoreGiderTutarlariToplami;

            }
            return View(filtreliKayitlar ?? new List<Models.KayitGelirGider>());
        }

        public ActionResult GelirGiderDetayliRapor()
        {
            return View(new List<Models.KayitGelirGider>());
        }
        [HttpPost]
        public ActionResult GelirGiderDetayliRapor(DateTime baslangicTarihi, DateTime bitisTarihi, string kayitTuru)
        {
  
            var filtreliKayitlar = KayitGelirGider.KayitList
                .Where(k => k.KayitTarih >= baslangicTarihi && k.KayitTarih <= bitisTarihi && kayitTuru == k.KayitTur)
                .ToList();

            if (!filtreliKayitlar.Any())
            {
                TempData["NoDataMessage"] = "Kayıt bulunamadı.";
                return RedirectToAction("GelirGiderDetayliRapor");
            }

            TempData["FilteredRecords"] = filtreliKayitlar;
            TempData["baslangicTarih"] = baslangicTarihi;
            TempData["bitisTarih"] = bitisTarihi;
            TempData["kayitTuru"] = kayitTuru;

            return RedirectToAction("DetayliRapor");
        }

        public ActionResult DetayliRapor()
        {
            var filtreliKayitlar = TempData["FilteredRecords"] as List<Models.KayitGelirGider>;

            if (filtreliKayitlar == null || !filtreliKayitlar.Any())
            {
                ViewBag.NoDataMessage = "Filtrelenmiş kayıt bulunamadı.";
            }
            else
            {
                ViewBag.GelirTutarlariToplami = filtreliKayitlar
                    .Where(k => k.KayitTur == "Gelir")
                    .Sum(k => k.Tutar);

                ViewBag.GiderTutarlariToplami = filtreliKayitlar
                    .Where(k => k.KayitTur == "Gider")
                    .Sum(k => k.Tutar);

                var baslangicTarihi = TempData["baslangicTarih"] as DateTime?;
                var bitisTarihi = TempData["bitisTarih"] as DateTime?;
                var kayitTuru = TempData["kayitTuru"] as string;

                if (baslangicTarihi.HasValue && bitisTarihi.HasValue)
                {
                    ViewBag.baslangicTarih = baslangicTarihi.Value.ToString("dd.MM.yyyy");
                    ViewBag.bitisTarih = bitisTarihi.Value.ToString("dd.MM.yyyy");
                }
                ViewBag.kayitTuru = kayitTuru;
            }

            return View(filtreliKayitlar ?? new List<Models.KayitGelirGider>());
        }

    }
}

