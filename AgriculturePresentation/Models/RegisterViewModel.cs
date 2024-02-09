using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Mail giriniz!")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi giriniz!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz!")]
        [Compare("Password", ErrorMessage = "Şifreler uygun değil")]
        public string PasswordConfirm { get; set; }

    }
}
