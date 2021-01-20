using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NearConnWebUI.Models
{
    public class KullaniciModel
    {
        [Required]
        public string KullaniciAdi { get; set; }
        [Required]
        public string KullaniciAdSoyad { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string KullaniciEmail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string KullaniciSifre { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("KullaniciSifre")]
        public string KullaniciSifreTekrar { get; set; }
        [Required]
        public string KullaniciAdres { get; set; }
        [Required]
        public string KullaniciTelefon { get; set; }
    }
}
