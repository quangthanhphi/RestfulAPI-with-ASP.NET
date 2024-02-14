using System;
namespace MagicVilla_VillaAPI.Models
{
    public class LoginResponseDTO
    {
        public LocalUser User { get; set; }
        public string Token { get; set; }
    }
}

