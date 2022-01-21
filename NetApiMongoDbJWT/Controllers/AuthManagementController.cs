using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NetApiMongoDbJWT.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetApiMongoDbJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthManagementController : ControllerBase
    {
       private readonly UserManager<ApplicationUser> _userManager;
        private readonly JwtConfig _jwtConfig;
        //     private readonly UserManager<ApplicationUser> _userManager;
        //private readonly SignInManager<ApplicationUser> _signInManager;
        public AuthManagementController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
    }
}
