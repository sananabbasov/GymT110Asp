using GymT110Asp.Data;
using GymT110Asp.Models;
using GymT110Asp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GymT110Asp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM vm = new HomeVM()
            {
                Sliders = _context.Sliders.ToList(),
                Products = _context.Products.ToList(),
                AboutLeft = _context.AboutLefts.FirstOrDefault(),
                AboutRights = _context.AboutRights.ToList(),
                Featureds = _context.Featureds.ToList(),
                Schedules = _context.Schedules.Include(x=>x.WeekDays).ToList()
            };

            return View(vm);
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
