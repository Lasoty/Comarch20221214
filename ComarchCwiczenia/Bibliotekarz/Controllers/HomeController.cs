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
                .Include(x => x.Borrower)
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

        [HttpGet("[action]/{id?}")]
        public IActionResult Edit(int? id)
        {
            EditViewModel vm;
            if (id == null)
            {
                vm = new EditViewModel()
                {
                    Book = new Book()
                    {
                        Borrower = new Customer()
                    }
                };
            }
            else
            {
                Book book = dbContext.Books.Include(book => book.Borrower).FirstOrDefault(x => x.Id == id);
                vm = new EditViewModel();

                if (book == null)
                {
                    vm.Book = new Book()
                    {
                        Borrower = new Customer()
                    };
                }
                else
                {
                    vm.Book = book;
                }
            }

            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit([FromForm] EditViewModel vm)
        {
            if (vm != null)
            {
                if (vm.Book.IsBorrowed)
                {
                    if (vm.Book.Borrower == null)
                    {
                        vm.Book.Borrower = new Customer();
                    }
                }
                else
                {
                    vm.Book.Borrower = null;
                }

                if (vm.Book.Id== 0)
                {
                    dbContext.Books.Add(vm.Book);
                }
                else
                {
                    dbContext.Books.Update(vm.Book);
                }

                dbContext.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

    }
}