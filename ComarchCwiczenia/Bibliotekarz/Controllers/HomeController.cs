using Bibliotekarz.Data.Context;
using Bibliotekarz.Data.Model;
using Bibliotekarz.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Bibliotekarz.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext dbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            dbContext.Database.Migrate();
            _logger = logger;
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel();
            vm.Books = dbContext.Books
                .OrderBy(x => x.Autor)
                .ThenByDescending(x => x.Title)
                .ToList();
            
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