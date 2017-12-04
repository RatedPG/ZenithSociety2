using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZenithWebSite.Models;
using ZenithWebSite.Data;
using Microsoft.EntityFrameworkCore;
using ZenithWebSite.Models.ZenithSocietyModels;

namespace ZenithWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            // client code with semi-arbitrary DateTime suuplied
            List<DateTime> week = GetCurrentWeek(DateTime.Today.AddDays(-2));
            var monday = week[0];
            var sunday = week[6].AddDays(1.0);
            var events = db.Events.Include(e => e.ActivityCategory)
                .Where(e => e.EventToDate <= sunday &&
                e.EventToDate >= monday && e.IsActive)
                .OrderBy(e => e.EventToDate);

            Dictionary<DateTime, IEnumerable<Event>> dict = new Dictionary<DateTime, IEnumerable<Event>>();

            foreach (var i in events)
            {
                if (!dict.ContainsKey(i.EventFromDate.Date))
                    dict.Add(i.EventFromDate.Date, events.Where(e => e.EventFromDate.Day == i.EventFromDate.Day
                    && e.EventFromDate.Month == i.EventFromDate.Month
                    && e.EventFromDate.Year == i.EventFromDate.Year));
            }

            ViewBag.events = dict;


            return View();
        }

        public static List<DateTime> GetCurrentWeek(DateTime today)
        {
            while (today.DayOfWeek != DayOfWeek.Monday)
                today = today.AddDays(-1.0);

            List<DateTime> week = new List<DateTime>();

            for (int i = 0; i < 7; i++)
            {
                week.Add(today);
                today = today.AddDays(1.0);
            }

            return week;
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}