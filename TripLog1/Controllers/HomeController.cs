using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TripLog1.Models;


namespace TripLog1.Controllers
{
    public class HomeController : Controller
    {

        private TripContext context { get; set; }

        public HomeController(TripContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index(Trip trips)
        {

            
            return View(trips);
           

            
        }
        
          

       
    }
}

    

