using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TysBooks.Models.ViewModels
{
    public class PageInfo
    {
       public int TotalNumBooks { get; set; }

       public int BooksPerPage { get; set; }

       public int CurrentPage { get; set; }

       //How many pages do we have?
       public int TotalPages => (int) Math.Ceiling((double) TotalNumBooks / BooksPerPage);
    }
}
