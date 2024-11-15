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
                KayitTarih = new DateTime(2024, 2, 11),
                KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                Tutar=754
            },
                new Models.KayitGelirGider
                {
                    Id = 2,
                    KayitTur = "Gelir",
                    KayitTarih = new DateTime(2024, 9, 10),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=554
                },
                new Models.KayitGelirGider
                {
                    Id = 3,
                    KayitTur = "Gider",
                    KayitTarih = new DateTime(2024, 11, 11),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=125
                },
                new Models.KayitGelirGider
                {
                    Id = 4,
                    KayitTur = "Gelir",
                    KayitTarih = new DateTime(2024, 11, 7),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=554
                },
                new Models.KayitGelirGider
                {
                    Id = 5,
                    KayitTur = "Gider",
                    KayitTarih = new DateTime(2018, 10, 5),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=156
                }
                ,
                new Models.KayitGelirGider
                {
                    Id = 6,
                    KayitTur = "Gelir",
                    KayitTarih = new DateTime(2024, 11, 12),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=165
                },
                new Models.KayitGelirGider
                {
                    Id = 7,
                    KayitTur = "Gider",
                    KayitTarih = new DateTime(2024, 11, 12),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=151
                },
                new Models.KayitGelirGider
                {
                    Id = 8,
                    KayitTur = "Gelir",
                    KayitTarih = new DateTime(2024, 11, 15),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=789
                },
                new Models.KayitGelirGider
                {
                    Id = 9,
                    KayitTur = "Gider",
                    KayitTarih = new DateTime(2024, 11, 15),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=324
                },
                new Models.KayitGelirGider
                {
                    Id = 10,
                    KayitTur = "Gelir",
                    KayitTarih = new DateTime(2024, 11, 13),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=1000
                },
                new Models.KayitGelirGider
                {
                    Id = 11,
                    KayitTur = "Gider",
                    KayitTarih = new DateTime(2024, 11, 13),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=247
                },
                new Models.KayitGelirGider
                {
                    Id = 12,
                    KayitTur = "Gelir",
                    KayitTarih = new DateTime(2024, 11, 14),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=754
                },
                new Models.KayitGelirGider
                {
                    Id = 13,
                    KayitTur = "Gider",
                    KayitTarih = new DateTime(2024, 11, 14),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=324
                }, new Models.KayitGelirGider
                {
                    Id = 14,
                    KayitTur = "Gelir",
                    KayitTarih = new DateTime(2023, 8, 4),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=752
                },
                new Models.KayitGelirGider
                {
                    Id = 15,
                    KayitTur = "Gider",
                    KayitTarih = new DateTime(2023, 1, 10),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=463
                },
                new Models.KayitGelirGider
                {
                    Id = 16,
                    KayitTur = "Gelir",
                    KayitTarih = new DateTime(2022, 3, 17),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=956
                },
                new Models.KayitGelirGider
                {
                    Id = 17,
                    KayitTur = "Gider",
                    KayitTarih = new DateTime(2022, 6, 25),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=648
                }
                ,
                new Models.KayitGelirGider
                {
                    Id = 18,
                    KayitTur = "Gelir",
                    KayitTarih = new DateTime(2021, 7, 29),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=984
                },
                new Models.KayitGelirGider
                {
                    Id = 19,
                    KayitTur = "Gider",
                    KayitTarih = new DateTime(2021, 2, 24),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=452
                },
                new Models.KayitGelirGider
                {
                    Id = 20,
                    KayitTur = "Gelir",
                    KayitTarih = new DateTime(2020, 5, 17),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=1233
                },
                new Models.KayitGelirGider
                {
                    Id = 21,
                    KayitTur = "Gider",
                    KayitTarih = new DateTime(2020, 9, 15),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=368
                },
                new Models.KayitGelirGider
                {
                    Id = 22,
                    KayitTur = "Gelir",
                    KayitTarih = new DateTime(2019, 11, 13),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=1500
                },
                new Models.KayitGelirGider
                {
                    Id = 23,
                    KayitTur = "Gider",
                    KayitTarih = new DateTime(2019, 11, 13),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=500
                },
                new Models.KayitGelirGider
                {
                    Id = 24,
                    KayitTur = "Gelir",
                    KayitTarih = new DateTime(2018, 4, 14),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=2000
                },
                new Models.KayitGelirGider
                {
                    Id = 25,
                    KayitTur = "Gider",
                    KayitTarih = new DateTime(2018, 8, 2),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=3200
                },
                 new Models.KayitGelirGider
                {
                    Id = 26,
                    KayitTur = "Gelir",
                    KayitTarih = new DateTime(2024, 11, 16),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=3000
                },
                new Models.KayitGelirGider
                {
                    Id = 27,
                    KayitTur = "Gider",
                    KayitTarih = new DateTime(2024, 11, 16),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=1700
                },
                new Models.KayitGelirGider
                {
                    Id = 28,
                    KayitTur = "Gelir",
                    KayitTarih = new DateTime(2024, 11, 17),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=7500
                },
                new Models.KayitGelirGider
                {
                    Id = 29,
                    KayitTur = "Gider",
                    KayitTarih = new DateTime(2024, 11, 17),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=3000
                },
                new Models.KayitGelirGider
                {
                    Id = 30,
                    KayitTur = "Gelir",
                    KayitTarih = new DateTime(2024, 11, 18),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=9500
                },
                new Models.KayitGelirGider
                {
                    Id = 31,
                    KayitTur = "Gider",
                    KayitTarih = new DateTime(2024, 11, 18),
                    KayitAciklama= "Lorem ipsum dolor sit amet consectetur adipisicing.",
                    Tutar=3200
                }

        };
    }
}