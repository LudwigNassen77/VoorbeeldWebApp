using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VoorbeeldGitHub.Models;

namespace VoorbeeldGitHub.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Gebruiker gebruiker = new Gebruiker();
            gebruiker.Start();
            return View(gebruiker);
        }
    }
}
