using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NearConnEL
{
    public class tbl_Kullanici
    {
        [Key]
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }
        public string KullaniciEmail { get; set; }
        public string KullaniciSifre { get; set; }
        public string KullaniciResim { get; set; }
        public string KullaniciAdres { get; set; }
        public string KullaniciTelefon { get; set; }
     
        public List<tbl_KullaniciEtkinlik> KullaniciEtkinliks { get; set; }
  

    }
}
