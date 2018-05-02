using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SORBA.Controllers
{
    [Route("api")]
    public class ApiController : Controller
    {
        [HttpGet]
        [Route("private-scoped")]
        [Authorize("read:users")]
        public IActionResult Scoped()
        {
            return Json(new
            {
                Message = "Hello from a private endpoint! You need to be authenticated and have a scope of read:users to see this."
            });
        }
    }
}