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
            //only show events not being attended by user
            if (User.Identity.IsAuthenticated)
            {
                var currentUser = _db.Users.Where(u => u.UserName == User.Identity.Name).SingleOrDefault();
                //tags of the user attending events
                List<AttendanceTag> tags = _db.AttendanceTags.Where(t=>t.Id==currentUser.Id).ToList();
                //for (int i = events.Count - 1; i >= 0; i--)
                //{
                //    //foreach(AttendanceTag t in tags)
                //    if (tags.Count > 0)
                //    {
                //        for (int j = tags.Count - 1; j >= 0; j--)
                //        {

                //            if (events[i] != null)
                //            {
                //                if(events[i].id == tags[j].EventId)
                //                {
                //                    events.Remove(events[i]);
                //                }

                //            }
                //        }
                //    }
                //}
            }
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
