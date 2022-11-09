using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pustok.Models;
using Pustok.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                FeaturedBooks = _context.Books.Include(x=>x.BookImages).Include(x=>x.Author).Where(x=>x.IsFeatured).Take(10).ToList(),
                NewBooks = _context.Books.Include(x=>x.BookImages).Include(x=>x.Author).Where(x=>x.IsNew).Take(10).ToList(),
                DiscountedBooks = _context.Books.Include(x=>x.BookImages).Include(x=>x.Author).Where(x=>x.DiscountPrice>0).Take(10).ToList()
            };

            return View(homeVM);
        }

        public IActionResult GetBook(int id)
        {
            Book book = _context.Books
                 .Include(x => x.BookImages).Include(x => x.Genre)
                 .Include(x => x.BookTags).ThenInclude(x => x.Tag)
                 .Include(x=>x.Author)
                 .FirstOrDefault(x => x.Id == id);

            return PartialView("_BookModalPartial",book);
        }

       
    }
}
