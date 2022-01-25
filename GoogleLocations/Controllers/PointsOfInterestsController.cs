using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoogleLocations.Models;

namespace GoogleLocations.Controllers
{
    public class PointsOfInterestsController : Controller
    {
        // GET: PointsOfInterestsController
        public ActionResult Index()
        {
            List<PointOfInterest> result = null;
            using (GoogleLocationContext context = new GoogleLocationContext())
            {
                result = context.PointsOfInterest.ToList();
            }

            return View(result);
        }

        // GET: PointsOfInterestsController/Details/5
        public ActionResult Details(int id)
        {
            PointOfInterest result = null;
            using (GoogleLocationContext context = new GoogleLocationContext())
            {
                result = context.PointsOfInterest.Where(x => x.LocationId == id).First();
            }

            return View(result);
        }

        // GET: PointsOfInterestsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PointsOfInterestsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: PointsOfInterestsController/Edit/5
        public ActionResult Edit(int id)
        {
            PointOfInterest result = null;
            using (GoogleLocationContext context = new GoogleLocationContext())
            {
                result = context.PointsOfInterest.Where(x => x.LocationId == id).First();
            }

            return View(result);
        }

        // POST: PointsOfInterestsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                using (GoogleLocationContext context = new GoogleLocationContext())
                {
                    PointOfInterest pointOfInterest = context.PointsOfInterest.Where(x => x.LocationId == id).First();
                    pointOfInterest.Name = collection["Name"];
                    pointOfInterest.Address = collection["Address"];
                    pointOfInterest.City = collection["City"];
                    pointOfInterest.State = collection["State"];
                    pointOfInterest.ZIP = int.Parse(collection["ZIP"]);

                    context.PointsOfInterest.Update(pointOfInterest);
                    context.SaveChanges();
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: PointsOfInterestsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PointsOfInterestsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
