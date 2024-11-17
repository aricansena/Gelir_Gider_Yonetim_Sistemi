using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Gelir_Gider_Yonetim_Sistemi.Models.GelirGiderVeri
{
    public class KayitGelirGider
    {
        public static List<Models.KayitGelirGider> KayitList = new List<Models.KayitGelirGider>()
        {

            new Models.KayitGelirGider
{
    Id = 1,
    KayitTur = "Gelir",
    KayitTarih = new DateTime(2024, 11, 21),
    KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 15000
},
new Models.KayitGelirGider
{
    Id = 2,
    KayitTur = "Gider",
    KayitTarih = new DateTime(2024, 11, 21),
    KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 5000
},
new Models.KayitGelirGider
{
    Id = 3,
    KayitTur = "Gelir",
    KayitTarih = new DateTime(2024, 3, 10),
    KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 12000
},
new Models.KayitGelirGider
{
    Id = 4,
    KayitTur = "Gider",
    KayitTarih = new DateTime(2024, 3, 15),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",    Tutar = 7000
},
new Models.KayitGelirGider
{
    Id = 5,
    KayitTur = "Gelir",
    KayitTarih = new DateTime(2024, 6, 25),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",    Tutar = 14000
},
new Models.KayitGelirGider
{
    Id = 6,
    KayitTur = "Gider",
    KayitTarih = new DateTime(2024, 6, 30),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",    Tutar = 8000
},
new Models.KayitGelirGider
{
    Id = 7,
    KayitTur = "Gelir",
    KayitTarih = new DateTime(2024, 9, 12),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 18000
},
new Models.KayitGelirGider
{
    Id = 8,
    KayitTur = "Gider",
    KayitTarih = new DateTime(2024, 9, 15),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 8000
},
new Models.KayitGelirGider
{
    Id = 9,
    KayitTur = "Gelir",
    KayitTarih = new DateTime(2024, 11, 16),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 20000
},
new Models.KayitGelirGider
{
    Id = 10,
    KayitTur = "Gider",
    KayitTarih = new DateTime(2024, 11, 20),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 1200
},
new Models.KayitGelirGider
{
    Id = 11,
    KayitTur = "Gelir",
    KayitTarih = new DateTime(2023, 7, 15),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 15000
},
new Models.KayitGelirGider
{
    Id = 12,
    KayitTur = "Gider",
    KayitTarih = new DateTime(2023, 7, 15),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 5000
},
new Models.KayitGelirGider
{
    Id = 13,
    KayitTur = "Gelir",
    KayitTarih = new DateTime(2022, 12, 5),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 13000
},
new Models.KayitGelirGider
{
    Id = 14,
    KayitTur = "Gider",
    KayitTarih = new DateTime(2022, 12, 5),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 4000
},
new Models.KayitGelirGider
{
    Id = 15,
    KayitTur = "Gelir",
    KayitTarih = new DateTime(2021, 3, 20),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 9500
},
new Models.KayitGelirGider
{
    Id = 16,
    KayitTur = "Gider",
    KayitTarih = new DateTime(2021, 3, 20),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 3500
},
new Models.KayitGelirGider
{
    Id = 17,
    KayitTur = "Gelir",
    KayitTarih = new DateTime(2020, 8, 25),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 18000
},
new Models.KayitGelirGider
{
    Id = 18,
    KayitTur = "Gider",
    KayitTarih = new DateTime(2020, 8, 25),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 7000
},
new Models.KayitGelirGider
{
    Id = 19,
    KayitTur = "Gelir",
    KayitTarih = new DateTime(2019, 6, 30),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 16000
},
new Models.KayitGelirGider
{
    Id = 20,
    KayitTur = "Gider",
    KayitTarih = new DateTime(2019, 6, 30),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 6000
},new Models.KayitGelirGider
{
    Id = 21,
    KayitTur = "Gider",
    KayitTarih = new DateTime(2024, 11, 16),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 3500
},new Models.KayitGelirGider
{
    Id = 22,
    KayitTur = "Gelir",
    KayitTarih = new DateTime(2024, 11, 18),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 6000
},new Models.KayitGelirGider
{
    Id = 23,
    KayitTur = "Gider",
    KayitTarih = new DateTime(2024, 11, 18),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 3500
},new Models.KayitGelirGider
{
    Id = 24,
    KayitTur = "Gelir",
    KayitTarih = new DateTime(2024, 11, 19),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 6000
},new Models.KayitGelirGider
{
    Id = 25,
    KayitTur = "Gider",
    KayitTarih = new DateTime(2024, 11, 19),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 3500
},new Models.KayitGelirGider
{
    Id = 24,
    KayitTur = "Gelir",
    KayitTarih = new DateTime(2024, 11, 20),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 6000
},new Models.KayitGelirGider
{
    Id = 25,
    KayitTur = "Gider",
    KayitTarih = new DateTime(2024, 11, 20),
KayitAciklama = "Lorem ipsum, dolor sit amet consectetur adipisicing elit.",
    Tutar = 3500
}
        };
    }
}