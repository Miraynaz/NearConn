using NearConnEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearConnWebUI.Models
{
    public class EtkinlikDetayModel
    {
        public tbl_Etkinlik Etkinlik { get; set; }
        public List<tbl_Kullanici> Kullanicilar { get; set; }
        public List<tbl_Etkinlik> Etkinlikler { get; set; }
    }
}
