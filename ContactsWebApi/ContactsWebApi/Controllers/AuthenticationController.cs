using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ContactsWebApi.Models;
using ContactsWebApi.Services;

namespace ContactsWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/authentication")]
    public class AuthenticationController : Controller
    {
        //private readonly IAzureTokenService _azureTokenService;

        //public AuthenticationController(IAzureTokenService azureTokenService)
        //{
        //    _azureTokenService = azureTokenService;
        //}

        [HttpPost]
        public async Task<IActionResult> Authenticate([FromBody] UserCredentials userCredentials)
        {
            //var token = await _azureTokenService.RequestAccessToken(authRequest.Username, authRequest.Password);
            //if (token != null)
            //{
            //    return new JsonResult(token);
            //}

            //return new UnauthorizedResult();
            return new JsonResult(userCredentials);
        }
    }
}