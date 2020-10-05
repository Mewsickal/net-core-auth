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
        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
            return new JsonResult("Got it");
        }
    }
}
