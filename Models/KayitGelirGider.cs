using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gelir_Gider_Yonetim_Sistemi.Models
{
    public class KayitGelirGider
    {
        public int Id { get; set; }
       
        [DisplayName("Kayıt Türü")]
        public string KayitTur { get; set; }

        [DisplayName("Kayıt Tarihi")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime KayitTarih { get; set; }

        [DisplayName("Kayıt Açıklaması")]
        public string KayitAciklama { get; set; }

        public int Tutar { get; set; }

        public IEnumerable<KayitGelirGider> Kayitlar { get; set; }
        public KayitGelirGider YeniKayit { get; set; }

    }
}