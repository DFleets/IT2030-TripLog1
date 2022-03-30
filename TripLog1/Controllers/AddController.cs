using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripLog1.Models;


namespace TripLog1.Controllers
{
    public class AddController : Controller
    {

        private TripContext context { get; set; }

        public AddController(TripContext ctx)
        {
            context = ctx;

        }

        [HttpGet]
        public IActionResult AddTrip()
        {
            ViewBag.Action = "Next"; 
            return View("AddTrip", new Trip());

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddInfo(int id)
        {
            ViewBag.Action = "Next";
            var AddTrip = context.Trips.Find(id);
            return View(AddTrip);
        }

        [HttpGet]
        public IActionResult AddThings(int id)
        {
            ViewBag.Action = "Next";
            var AddTrip = context.Trips.Find(id);
            return View(AddTrip);
        }

        [HttpPost]
        public IActionResult AddInfo( Trip addTrip)
        {
            if (ModelState.IsValid)
            {
                if (addTrip.Accommodations != null)
                    context.Trips.Add(addTrip);
                else
                    context.Trips.Update(addTrip);
                context.SaveChanges();
                return RedirectToAction("Next", "AddThings");      
            }
            else
            {
                ViewBag.Action = (addTrip.Accommodations == null) ? "Next":"Next" ;
                 return View(addTrip);
                ;
            }

        }

        [HttpPost]
        public IActionResult AddThings(Trip addTrip)
        {
            context.Trips.Update(addTrip);
            context.SaveChanges();
            return View(addTrip);
        }

      
    }
}
