using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NearConnBL.Abstract;
using NearConnEL;
using NearConnWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearConnWebUI.Controllers.Etkinlik
{
    
    public class EtkinlikController : Controller
    {
        private IEtkinlikService _etkinlikService;
        public EtkinlikController(IEtkinlikService etkinlikService)
        {
            _etkinlikService = etkinlikService;
        }
        [HttpGet]
  
        public ActionResult EtkinlikEkle()
        {
            return View();
        }
        [HttpGet]

        public ActionResult EtkinlikGuncelle(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _etkinlikService.GetById((int)id);
            var model = new EtkinlikModel
            {
                EtkinlikId = entity.EtkinlikId,
                EtkinlikAciklama = entity.EtkinlikAciklama,
                EtkinlikAdi = entity.EtkinlikAdi,
                EtkinlikAdres = entity.EtkinlikAdres,
                EtkinlikResim = entity.EtkinlikResim
            };
            return View(model);
        }
        [HttpGet]
    
        public ActionResult EtkinlikListele()
        {

            return View(new EtkinlikDetayModel()
            {
                Etkinlikler = _etkinlikService.GetAll()
            }) ;
        }
        [HttpGet]
   
        public ActionResult EtkinlikOnay()
        {
            return View(new EtkinlikDetayModel()
            {
                Etkinlikler = _etkinlikService.GetAll()
            });

        } 
        [HttpGet]

        public ActionResult EtkinlikDetay(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            tbl_Etkinlik tbl_Etkinlik = _etkinlikService.GetTbl_EtkinlikDetails((int)id);
            if (tbl_Etkinlik == null)
            {
                return NotFound();
            }
            return View(new EtkinlikDetayModel()
            {
                Etkinlik = tbl_Etkinlik,
                Kullanicilar = tbl_Etkinlik.KullaniciEtkinliks.Select(i => i.Kullanici).ToList()
            }) ;
        } 


       
        
        [HttpPost]
      
        public ActionResult EtkinlikEkle(EtkinlikModel etkinlikModel)
        {
            var etkinlikEntity = new tbl_Etkinlik()
            {

                EtkinlikAdi = etkinlikModel.EtkinlikAdi,
                EtkinlikAdres = etkinlikModel.EtkinlikAdres,
                EtkinlikTarih = etkinlikModel.EtkinlikTarih,
                EtkinlikResim = etkinlikModel.EtkinlikResim,
                EtkinlikAciklama = etkinlikModel.EtkinlikAciklama,
                EtkinlikDurum = false 

            };
            _etkinlikService.Create(etkinlikEntity);

            return RedirectToAction("EtkinlikListele");


        }
        [HttpPost]
      
        public ActionResult EtkinlikGuncelle(EtkinlikModel etkinlikModel)
        {
            var entity = _etkinlikService.GetById(etkinlikModel.EtkinlikId);
            if (entity == null)
            {
                return NotFound();
            }
            entity.EtkinlikAdi = etkinlikModel.EtkinlikAdi;
            entity.EtkinlikAdres = etkinlikModel.EtkinlikAdres;
            entity.EtkinlikAciklama = etkinlikModel.EtkinlikAciklama;
            entity.EtkinlikTarih = etkinlikModel.EtkinlikTarih;
            _etkinlikService.Update(entity);
            return RedirectToAction("EtkinlikListele");
        }
       
        [HttpPost]

        public ActionResult EtkinlikOnay(EtkinlikModel etkinlikModel)
        {
            var entity = _etkinlikService.GetById(etkinlikModel.EtkinlikId);
            if (entity == null)
            {
                return NotFound();
            }
            entity.EtkinlikDurum = true;
            _etkinlikService.Update(entity);
            return RedirectToAction("EtkinlikOnay");
        }
        [HttpPost]

        public ActionResult EtkinlikSil(int etkinlikId)
        {
            var entity = _etkinlikService.GetById(etkinlikId);
            if (entity != null)
            {
                _etkinlikService.Delete(entity);
            }
            return RedirectToAction("EtkinlikListele");
        }

    }
}
