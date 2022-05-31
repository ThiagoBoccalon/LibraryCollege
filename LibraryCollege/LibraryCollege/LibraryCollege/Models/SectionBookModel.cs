using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCollege.Models
{
    public class SectionBookModel
    {
        public string Name { get; set; }
        public List<BookModel> Books { get; set; }
    }
}
