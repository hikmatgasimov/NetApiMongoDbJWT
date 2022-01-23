using NetApiMongoDbJWT.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetApiMongoDbJWT.Models.RequestDto
{
    public class UserLoginRequest : AuthResult
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
