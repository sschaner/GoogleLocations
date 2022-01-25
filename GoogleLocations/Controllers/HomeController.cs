using GoogleLocations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleLocations.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<PointOfInterest> result = null;

            using (GoogleLocationContext context = new GoogleLocationContext())
            {
                result = context.PointsOfInterest.ToList();
            }

            return View(result);
        }

        public IActionResult SavePointOfInterest(PointOfInterest pointOfInterest)
        {
            using (GoogleLocationContext context = new GoogleLocationContext())
            {
                context.PointsOfInterest.Add(pointOfInterest);
                context.SaveChanges();
            }

            return Redirect("/");
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
