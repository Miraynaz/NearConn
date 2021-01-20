using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearConnWebUI.Identity
{
    public class ApplicationUser:IdentityUser
    {
        public string KullaniciAdi { get; set; }
        public string KullaniciAdres { get; set; }
    }
}
