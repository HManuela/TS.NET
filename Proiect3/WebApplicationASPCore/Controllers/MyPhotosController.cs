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
    public class MyPhotosController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public MyPhotosController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ServiceReference1.Service1 ph =
                         new ServiceReference1.Service1();
            ServiceReference1.MyPhotos myPhotos = ph.GetAllPhotos();
            return View(myPhotos);
        }

        public IActionResult IndexPhoto()
        {
            ServiceReference1.Service1 ph =
                         new ServiceReference1.Service1();
            ServiceReference1.MyPhotos myPhotos = ph.FindPhotoById();
            return View(myPhotos.Photo);
        }

        public IActionResult PathPhoto()
        {
            ServiceReference1.Service1 ph =
                         new ServiceReference1.Service1();
            ServiceReference1.MyPhotos myPhotos = ph.GetPath();
            return View(myPhotos.PathPhoto);
        }

        public IActionResult DescriptionPhoto()
        {
            ServiceReference1.Service1 ph =
                         new ServiceReference1.Service1();
            ServiceReference1.DetaliiPhoto  photo = ph.GetDescription();
            return View(DetaliiPhoto.descriere);
        }

        public IActionResult TitlePhoto()
        {
            ServiceReference1.Service1 ph =
                         new ServiceReference1.Service1();
            ServiceReference1.DetaliiPhoto photo = ph.GetTitle();
            return View(DetaliiPhoto.titlu);
        }

        public IActionResult PeoplePhoto()
        {
            ServiceReference1.Service1 ph =
                         new ServiceReference1.Service1();
            ServiceReference1.DetaliiPhoto photo = ph.GetPeople();
            return View(DetaliiPhoto.people);
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
