using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LayoutAndPartial.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("Detail")]
        public IActionResult Detail()
        {
            return View("~/Views/Users/UserDetail.cshtml");
        }
    }
}
