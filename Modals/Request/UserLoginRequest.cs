using System.ComponentModel.DataAnnotations;

namespace JwelryBackendSide.Modals.Request
{
    public class UserLoginRequest
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
