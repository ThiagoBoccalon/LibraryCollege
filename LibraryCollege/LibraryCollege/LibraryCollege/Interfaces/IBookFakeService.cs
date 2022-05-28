using LibraryCollege.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCollege.Interfaces
{
    public interface IBookFakeService
    {
        List<BookModel> GetBooks();
    }
}
