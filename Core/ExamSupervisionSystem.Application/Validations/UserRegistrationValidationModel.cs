using System;
using System.ComponentModel.DataAnnotations;
namespace ExamSupervisionSystem.Application.Validations
{
    public class UserRegistrationValidationModel
    {
        [Required(ErrorMessage = "Kullanıcı adı gereklidir.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Kullanıcı adı 3 ile 50 karakter arasında olmalıdır.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre gereklidir.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Şifre 6 ile 100 karakter arasında olmalıdır.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Ad alanı gereklidir.")]
        [StringLength(50, ErrorMessage = "Ad alanı en fazla 50 karakter olabilir.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad alanı gereklidir.")]
        [StringLength(50, ErrorMessage = "Soyad alanı en fazla 50 karakter olabilir.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "E-posta adresi gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi girin.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Cinsiyet alanı gereklidir.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Doğum tarihi gereklidir.")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    }
}