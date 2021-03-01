using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JwelryBackendSide.Abstraction.BusinessLayer;
using JwelryBackendSide.Modals.Request;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwelryBackendSide.Controllers
{
    [Route("api/jewelry/")]
    [ApiController]
    public class JewelryController : ControllerBase
    {
        private readonly IJwelryBusinessLogic _jwelryBusinessLogic;
        public JewelryController(IJwelryBusinessLogic jwelryBusinessLogic)
        {
            _jwelryBusinessLogic = jwelryBusinessLogic;
        }
        [EnableCors("AllowAll")]
        [HttpPost("userlogin")]
        public async Task<ActionResult> UserLogin(UserLoginRequest userLoginRequest)
        {
            var result = await _jwelryBusinessLogic.UserLogin(userLoginRequest);
            if (result != null)
            {
                return Created("Login Sucessfully", result);
            }
            else
            {
                return BadRequest("Please try again..");
            }
        }
    }
}