using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EventManager.Models;
using Microsoft.AspNetCore.Identity;

namespace EventManager.Controllers
{
    public class EventController : Controller
    {
        public SignInManager<ApplicationUser> _signInManager;
        public UserManager<ApplicationUser> _userManager;

        private readonly ApplicationDbContext _db;

        public EventController(ApplicationDbContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        //[HttpPost]
        public IActionResult AttendEvent(int id)
        {
            if (User.Identity.IsAuthenticated) {
                ApplicationUser currentUser = _db.Users.Where(u => u.UserName == User.Identity.Name).Single();
                Event anEvent = _db.Events.Where(e => e.EventId == id).Single();
                AttendanceTag tag = new AttendanceTag
                {
                    Id = currentUser.Id,
                    EventId = id
                };
                if (_db.AttendanceTags.Where(t=>t.Id == tag.Id).Where(t=>t.EventId == tag.EventId).Count() == 0) { 
                    _db.Add(tag);
                    _db.SaveChanges();
                }
            }else
            {
               return RedirectToAction("Login", "Account");
            }
            return RedirectToAction("Index","Home");
        }
        public IActionResult CreateEvent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEvent(Event anEvent)
        {
            ApplicationUser currentUser = _db.Users.Where(u => u.UserName == User.Identity.Name).Single();
            anEvent.artist = currentUser;
            anEvent.Id = currentUser.Id;
            anEvent.isCanceled = false;

            if (ModelState.IsValid)
            {
                _db.Events.Add(anEvent);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(anEvent);
        }
        public IActionResult EditEvent()
        {
            return View();
        }
        [HttpPut]
        public IActionResult EditEvent(Event anEvent)
        {
            if (ModelState.IsValid)
            {
                _db.Update(anEvent);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");

            }
            return View(anEvent);
        }
        public IActionResult CancelEvent()
        {
            return View();
        }
    }
}