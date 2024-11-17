using Gelir_Gider_Yonetim_Sistemi.Models;
using Gelir_Gider_Yonetim_Sistemi.Models.GelirGiderVeri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gelir_Gider_Yonetim_Sistemi.Controllers
{
    public class KayitController : Controller
    {
   
        public ActionResult KayitSil(int id)
        {
            var kayit = Models.GelirGiderVeri.KayitGelirGider.KayitList.FirstOrDefault(k => k.Id == id);

            if (kayit != null)
            {
                Models.GelirGiderVeri.KayitGelirGider.KayitList.Remove(kayit);
            }

            return RedirectToAction("KayitListele");
        }
        public ActionResult KayitListele()
        {
            var kayitList = Models.GelirGiderVeri.KayitGelirGider.KayitList.OrderByDescending(t=>t.KayitTarih).ToList();
            return View(kayitList);
        }

        public ActionResult KayitEkle()
        {
            return View(new Models.KayitGelirGider());
        }

        [HttpPost]
        public ActionResult KayitEkle(Models.KayitGelirGider yeniKayit) 
        {
            if (ModelState.IsValid)
            {
                var eklenecekKayit = new Models.KayitGelirGider
                {
                    KayitTur = yeniKayit.KayitTur,
                    KayitTarih = yeniKayit.KayitTarih,
                    KayitAciklama = yeniKayit.KayitAciklama,
                    Tutar = yeniKayit.Tutar
                };
                Models.GelirGiderVeri.KayitGelirGider.KayitList.Add(eklenecekKayit);

                return RedirectToAction("KayitListele");
            }
            return View(yeniKayit);
        }
        public ActionResult KayitEdit(int id)
        {
            var kayit = Models.GelirGiderVeri.KayitGelirGider.KayitList.FirstOrDefault(k => k.Id == id);
            if (kayit == null)
            {
                return HttpNotFound();
            }
            return View("KayitListele", kayit);
        }


        [HttpPost]
        public ActionResult KayitEdit(Models.KayitGelirGider kayit)
        {
            if (ModelState.IsValid)
            {
                var existingKayit = Models.GelirGiderVeri.KayitGelirGider.KayitList.FirstOrDefault(k => k.Id == kayit.Id);
                if (existingKayit != null)
                {
                    existingKayit.KayitTur = kayit.KayitTur;
                    existingKayit.KayitTarih = kayit.KayitTarih;
                    existingKayit.KayitAciklama = kayit.KayitAciklama;
                    existingKayit.Tutar = kayit.Tutar;
                }
                return RedirectToAction("KayitListele");
            }
            return View(kayit);
        }

    }
}

