using System.ComponentModel.DataAnnotations;

namespace DemoRRHH.ViewModel
{
    public class RegisterInputModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Insert user name")]
        public string Username { get; set; } = string.Empty;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Insert email")]
        public string Email { get; set; } = string.Empty;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Insert password")]
        public string Password { get; set; } = string.Empty;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirm password")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
