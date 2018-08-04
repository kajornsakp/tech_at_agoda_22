using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using techatagoda22.Services;

namespace techatagoda22.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = new NameService().GetName("");
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
