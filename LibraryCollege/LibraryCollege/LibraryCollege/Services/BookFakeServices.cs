using LibraryCollege.Interfaces;
using LibraryCollege.Models;
using LibraryCollege.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(BookFakeServices))]
namespace LibraryCollege.Services
{
    public class BookFakeServices : IBookFakeService
    {
        private List<BookModel> _books;

        private void StartBooks()
        {
            _books = new List<BookModel>()
            {
                new BookModel(){ 
                    Image = "book_one.png"
                    },

                new BookModel(){
                    Image = "book_two.png"
                    }
                
            };
        }

        public List<BookModel> GetBooks()
        {
            StartBooks();
            return _books;
        }
    }
}
