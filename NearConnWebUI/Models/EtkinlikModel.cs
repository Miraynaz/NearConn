using NearConnEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearConnWebUI.Models
{
    public class EtkinlikModel
    {
        public int EtkinlikId { get; set; }
        public string EtkinlikAdi { get; set; }
        public string EtkinlikAdres { get; set; }
        public string EtkinlikResim { get; set; }
        public string EtkinlikAciklama { get; set; }
        public DateTime EtkinlikTarih { get; set; }
        public bool EtkinlikDurum { get; set; }
  
    }
}
