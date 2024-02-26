using System.ComponentModel.DataAnnotations;

namespace CurrencyMVC.Models.DTOs
{
    public class CreateCurrencyDto
    {
        [Required(ErrorMessage ="Döviz İsim Alanı Boş Geçilemez")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Döviz Html İsim Alanı Boş Geçilemez")]
        public string? AttributeName { get; set; }
    }
}
