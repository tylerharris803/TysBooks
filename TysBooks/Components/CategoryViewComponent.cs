using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TysBooks.Models;

namespace TysBooks.Components
{
    public class CategoryViewComponent : ViewComponent
    {
        private ITysBooksRepository repo { get; set; }

        public CategoryViewComponent (ITysBooksRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["bookCategory"];

            var categories = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);


            return View(categories);
        }
    }
}
