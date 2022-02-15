using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace TysBooks.Models
{
    public class EFTysBooksRepository : ITysBooksRepository
    {

        private BookstoreContext context { get; set; }

        public EFTysBooksRepository(BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Books> Books => context.Books;
    }
}
