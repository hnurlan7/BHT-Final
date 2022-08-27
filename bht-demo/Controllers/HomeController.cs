using bht_demo.DAL;
using bht_demo.Models;
using bht_demo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace bht_demo.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.settings = _context.Settings.FirstOrDefault();
            homeVM.sliders = _context.Sliders.ToList();
            homeVM.certificates = _context.Certificates.ToList();
            homeVM.places = _context.Places.ToList();
            homeVM.Tours = _context.Tours.Where(c => c.IsDeleted == false).Include(t => t.Category).OrderByDescending(b => b.Id).Take(4).ToList();

            return View(homeVM);
        }
    }
}
