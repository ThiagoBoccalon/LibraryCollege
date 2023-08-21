using LibraryCollege.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCollege.Models
{
    public class BookModel
    {   
        public string Image { get; set; }
        public string NavigationToPage { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public BookFlag BookFlag { get; set; }
    }
}
