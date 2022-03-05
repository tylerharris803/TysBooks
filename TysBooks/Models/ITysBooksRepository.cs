using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TysBooks.Models
{
    public interface ITysBooksRepository
    { 
        IQueryable<Books> Books { get; }

        public void SaveBook(Books b);

        public void CreateBook(Books b);

        public void DeleteBook(Books b);

    }
}
