using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace EventManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            List<Event> events = _db.Events.ToList();    
            return View(events);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
