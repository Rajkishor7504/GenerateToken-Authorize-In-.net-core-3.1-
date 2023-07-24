using JWTTokenAPIMASTERCreate.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTTokenAPIMASTERCreate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameDetailsController : Controller
    {
        private readonly IJWTManager _ijwtmanager;
        public NameDetailsController(IJWTManager ijwtmanager)
        {
            _ijwtmanager = ijwtmanager;
        }
        [Authorize]
        [HttpPost]
        [Route("GetNames")]
        public IActionResult GetName(UserCredential obj)
        {
            return Ok(new List<string> {obj.username,obj.password });
        }
    }
}
