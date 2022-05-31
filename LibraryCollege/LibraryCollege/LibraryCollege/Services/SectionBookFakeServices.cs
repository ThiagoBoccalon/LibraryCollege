using LibraryCollege.Interfaces;
using LibraryCollege.Models;
using LibraryCollege.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(SectionBookFakeServices))]
namespace LibraryCollege.Services
{
    public class SectionBookFakeServices : ISectionBookFakeService
    {
        private List<BookModel> _booksAvaliableToYou;
        private List<BookModel> _booksBooksMoreRead;
        private List<BookModel> _booksBestRated;
        private List<BookModel> _booksRecommended;

        private void StartBooksAvaliableToYou()
        {
            _booksAvaliableToYou = new List<BookModel>()
            {
                new BookModel(){
                        Image = "book_one.png",
                        NavigationToPage = "Profile"
                },

                new BookModel(){
                        Image = "book_four.png",
                        NavigationToPage = "Profile"
                }
            };
        }

        private void StartBooksMoreRead()
        {
            _booksBooksMoreRead = new List<BookModel>()
            {
                new BookModel(){
                        Image = "book_three.png",
                        NavigationToPage = "Profile"
                },

                new BookModel(){
                        Image = "book_five.png",
                        NavigationToPage = "Profile"
                }
            };
        }

        private void StartBooksBestRated()
        {
            _booksBestRated = new List<BookModel>()
            {
                new BookModel(){
                        Image = "book_three.png",
                        NavigationToPage = "Profile"
                },

                new BookModel(){
                        Image = "book_five.png",
                        NavigationToPage = "Profile"
                }
            };
        }

        private void StartBooksRecommended()
        {
            _booksRecommended = new List<BookModel>()
            {
                new BookModel(){
                        Image = "book_three.png",
                        NavigationToPage = "Profile"
                },

                new BookModel(){
                        Image = "book_five.png",
                        NavigationToPage = "Profile"
                }
            };
        }

        public List<BookModel> GetBooksAvaliableToYou()
        {
            StartBooksAvaliableToYou();            
            return _booksAvaliableToYou;
        }

        public List<BookModel> GetBooksMoreRead()
        {
            StartBooksMoreRead();
            return _booksBooksMoreRead;
        }

        public List<BookModel> GetBooksBestRated()
        {
            StartBooksBestRated();
            return _booksBestRated;
        }

        public List<BookModel> GetBooksRecommended()
        {
            StartBooksRecommended();
            return _booksRecommended;
        }
    }
}
