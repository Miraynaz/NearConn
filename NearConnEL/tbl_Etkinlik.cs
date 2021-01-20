using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NearConnEL
{
    public class tbl_Etkinlik
    {
        [Key]
        public int EtkinlikId { get; set; }
        public string EtkinlikAdi{ get; set; }
        public string EtkinlikAdres{ get; set; }
        public string EtkinlikResim{ get; set; }
        public string EtkinlikAciklama{ get; set; }
        public DateTime EtkinlikTarih{ get; set; }
        public bool EtkinlikDurum{ get; set; }


        public List<tbl_KullaniciEtkinlik> KullaniciEtkinliks { get; set; }

    }
}
