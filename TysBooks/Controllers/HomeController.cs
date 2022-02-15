using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TysBooks.Models;
using TysBooks.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TysBooks.Controllers
{
    public class HomeController : Controller
    {
        private ITysBooksRepository repo;

        public HomeController(ITysBooksRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(int pageNum = 1) //starts at the beginning
        {
            int pageSize = 10;

            var x = new BooksViewModel
            {
                Books = repo.Books
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = repo.Books.Count(),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum

                }
            };

            return View(x);
        }
    }
}
