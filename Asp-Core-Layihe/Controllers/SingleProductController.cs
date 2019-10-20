using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Asp_Core_Layihe.Controllers
{
    public class SingleProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}