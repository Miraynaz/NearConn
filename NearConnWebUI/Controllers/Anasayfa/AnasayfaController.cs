using Microsoft.AspNetCore.Mvc;
using NearConnBL.Abstract;
using NearConnWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearConnWebUI.Controllers.Anasayfa
{
    public class AnasayfaController : Controller
    {
        private IEtkinlikService _etkinlikService;
        public AnasayfaController(IEtkinlikService etkinlikService)
        {
            _etkinlikService = etkinlikService;
        }
    
        [HttpGet]
        public ActionResult Anasayfa()
        {
            return View(new EtkinlikDetayModel()
            {
                Etkinlikler = _etkinlikService.GetAll()
            });
        }
    }
}
