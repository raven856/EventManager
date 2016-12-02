using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EventManager.Models;

namespace EventManager.Controllers
{
    public class EventController : Controller
    {
        public IActionResult EventIndex()
        {
            return View();
        }
        public IActionResult AttendEvent()
        {
            return View();
        }
        public IActionResult CreateEvent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEvent(Event anEvent)
        {
            return View();
        }
        public IActionResult CancelEvent()
        {
            return View();
        }
    }
}