using System.ComponentModel.DataAnnotations;

namespace DemoRRHH.ViewModel
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese su usuario")]
        public string Username { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese su contraseña")]
        public string Password { get; set; } = string.Empty;
    }
}
