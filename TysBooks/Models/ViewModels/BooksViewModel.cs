using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TysBooks.Models.ViewModels
{
    public class BooksViewModel
    {
        public IQueryable<Books> Books { get; set; }

        public PageInfo PageInfo { get; set; }
    }
}
