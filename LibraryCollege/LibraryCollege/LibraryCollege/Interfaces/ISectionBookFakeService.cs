﻿using LibraryCollege.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCollege.Interfaces
{
    public interface ISectionBookFakeService
    {
        List<BookModel> GetBooksAvaliable();        
        List<BookModel> GetBooksMoreRead();
        List<BookModel> GetBooksBestRated();
        List<BookModel> GetBooksRecommended();
    }
}
