using System;
using System.Collections.Generic;
using System.Text;

namespace NearConnEL
{
    public class tbl_KullaniciEtkinlik
    {

        public int KullaniciId { get; set; }
        public tbl_Kullanici Kullanici { get; set; }
        public int EtkinlikId { get; set; }
        public tbl_Etkinlik Etkinlik { get; set; }
    }
}
