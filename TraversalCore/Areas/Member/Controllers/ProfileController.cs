using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Areas.Member.Models;

namespace TraversalCore.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.name = values.Name;
            userEditViewModel.surname = values.Surname;
            userEditViewModel.phoneNumber = values.PhoneNumber;
            userEditViewModel.mail = values.Email;
            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            //İsme göre kullanıcıyı bul
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            //TODO (Fotoğraf eklerken eski fotoğrafı dosyadan silecek.)

            //Eğer kullanıcı resim ekliyorsa
            if (p.image != null)
            {
                //kaynak şuan olduğum proje
                var resource = Directory.GetCurrentDirectory();
                //Uzantı eklenen resmin adı
                var extension = Path.GetExtension(p.image.FileName);
                //Resim isimleri çatışmasın diye ratgele değer üreten guid kullandık.
                var imageName = Guid.NewGuid() + extension;
                //Resmin yolunu verdik
                var saveLocation = resource + "/wwwroot/userImages/" + imageName;
                //verilen lokasyona dosya ekle.
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.image.CopyToAsync(stream);
                user.ImageUrl = imageName;
            }
            user.Name = p.name;
            user.Surname = p.surname;
            if (p.password != null)
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.password);
            }
            user.PhoneNumber = p.phoneNumber;
            user.Email = p.mail;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }
            return View();
        }
    }
}
