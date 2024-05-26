using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Models;

namespace TraversalCore.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        //sınıf içerisinde kullanılabilir ve sadece burada değer atanabilir ve değiştirilebilir kılar.
        //sınıfın diğer metodları içinde yanlışlıkla değiştirilmesini önler ve güvenliğini sağlar.
        
        //Kayıt Ol
        private readonly UserManager<AppUser> _userManager;

        //Giriş yap
        private readonly SignInManager<AppUser> _signInManager;

        //Ortak Const
        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }




        //  **************  KAYIT OL  **************

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        //Identity'e ait işlemler yapılacağı için async olmalı.
        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel p)
        {
            AppUser appUser = new AppUser()
            {
                Name = p.Name,
                Surname = p.Surname,
                UserName = p.Username,
                Email = p.Mail   
            };
            //Şifrelerin aynı olup olmadığını kontrol ediyorum
            //Şifreyi yukarıdakiler gibi veremiyorum çünkü veritabanına hashlenerek kayıt ediliyor.
            if (p.Password == p.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, p.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }

        //  **************  GİRİŞ YAP  **************

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserSignInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.Username, p.Password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile", new { area="Member"});
                }
                else
                {
                    return RedirectToAction("SignIn", "Login");
                }
            }
            return View();
        }
    }
}
