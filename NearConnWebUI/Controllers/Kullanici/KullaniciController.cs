using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NearConnBL.Abstract;
using NearConnEL;
using NearConnWebUI.Identity;
using NearConnWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearConnWebUI.Controllers.Kullanici
{
    [AutoValidateAntiforgeryToken]
    public class KullaniciController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private IEmailSender _emailSender;
        public KullaniciController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }
        [HttpGet]
        public ActionResult GirisYap()
        {
            return View(new LoginModel());
        }

        [HttpGet]
        public ActionResult KullaniciKayit()
        {
            return View(new KullaniciModel());
        }
        
    
        [HttpGet]
        public ActionResult KullaniciGuncelle()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SifreyiYenile()
        {
          
            return View(new SifreyiYenileModel());
        }

        [HttpPost]
        public async Task<ActionResult>  GirisYap(LoginModel loginModel,string returnUrl)
        {
            returnUrl = returnUrl ?? "~/";
            if (!ModelState.IsValid)
            {
                return View(loginModel);
            }
            var user = await _userManager.FindByNameAsync(loginModel.KullaniciAdi);
            if (user == null)
            {
                ModelState.AddModelError("","Böyle bir kullanıcı bulunamadı");
            }
            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Lütfen hesabınızı email ile onaylayınız");
            }
            {
                ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı");
            }
            var result = await _signInManager.PasswordSignInAsync(loginModel.KullaniciAdi, loginModel.KullaniciSifre, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Anasayfa", "Anasayfa");
            }
            return View(loginModel);
        } 
        
        [HttpPost]
        public async Task<ActionResult> KullaniciKayit(KullaniciModel kullaniciModel)
        {
            if (!ModelState.IsValid)
            {
                return View(kullaniciModel);
            }
            var user = new ApplicationUser
            {
                UserName = kullaniciModel.KullaniciAdi,
                Email = kullaniciModel.KullaniciEmail,
                KullaniciAdi = kullaniciModel.KullaniciAdSoyad,
                KullaniciAdres = kullaniciModel.KullaniciAdres,
                PhoneNumber = kullaniciModel.KullaniciTelefon
            };
            var result = await _userManager.CreateAsync(user, kullaniciModel.KullaniciSifre);
            if (result.Succeeded)
            {
                var code = _userManager.GenerateEmailConfirmationTokenAsync(user);
                var callbackUrl = Url.Action("ConfirmaEmail", "Kullanici", new
                {
                    userId = user.Id,
                    token = code.Result
                });
                await _emailSender.SendEmailAsync(kullaniciModel.KullaniciEmail, "Hesabınızı Onaylayın", $"Lütfen hesabınızı onaylamak için linke <a href='https//localhost:44361{callbackUrl}'>tıklayın</a>");
                return RedirectToAction("GirisYap", "Kullanici");
            }
            ModelState.AddModelError("","Bilinmeyen bir hatadan dolayı işlem gerçekleşemiyor lütfen tekrar deneyiniz!");
            return View();
        }
        
        [HttpPost]
        public ActionResult KullaniciGuncelle(KullaniciModel kullaniciModel)
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> CikisYap()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("GirisYap", "Kullanici");
        }
        [HttpGet]
        public async Task<ActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                TempData["message"] = "Geçersiz Token";
                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    TempData["mesaj"] = "Hesabınız onaylandı";
                    return View();
                }
            }
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> SifreyiYenile(SifreyiYenileModel sifreyiYenileModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var user = await _userManager.FindByNameAsync(sifreyiYenileModel.Email);
            if (user == null)
            {
                return View();
            }
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync( user,token,sifreyiYenileModel.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("GirisYap","Kullanici");
            }
            return View(sifreyiYenileModel);
        }
    }
}
