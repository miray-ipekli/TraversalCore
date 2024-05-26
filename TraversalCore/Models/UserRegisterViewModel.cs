using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen adınızı giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen e-postanızı giriniz.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi tekrar giriniz.")]
        [Compare("Password", ErrorMessage ="Şifreler birbiri ile eşleşmiyor.")]
        public string ConfirmPassword { get; set; }
    }
}
