using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationASPCore.Models;

namespace WebApplicationASPCore.Controllers
{
    public class UsersController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public UsersController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ServiceReference1.Service1 ph =
                         new ServiceReference1.Service1();
            ServiceReference1.MyPhotos myPhotos = ph.FindUserById(1);
            return View(User);
        }

        public IActionResult AllIndex()
        {
            ServiceReference1.Service1 ph =
                         new ServiceReference1.Service1();
            ServiceReference1.MyPhotos myPhotos = ph.GetAllUsers();
            return View(User);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
