using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Policy = "Api1Scope")]
        [HttpGet]
        public IActionResult Index()
        {
            return new JsonResult("Got it");
        }

        [Authorize(Policy = "SecretApiScope")]
        [HttpGet]
        public IActionResult GetSecret()
        {
            return new JsonResult("Got secret :O");
        }
    }
}
