using JWTTokenAPIMASTERCreate.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTTokenAPIMASTERCreate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JwtGetTokenAPIController : ControllerBase
    {
        private readonly IJWTManager _ijwtmanager;
        public JwtGetTokenAPIController(IJWTManager ijwtmanager)
        {
            _ijwtmanager = ijwtmanager;
        }
        public string GenerateToken()
        {
            var token = _ijwtmanager.GetToken("Sample", "password");
            return token;
        } 
       
    }
}
