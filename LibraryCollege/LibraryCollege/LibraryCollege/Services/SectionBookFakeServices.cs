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
                        Image = "book_01.png",
                        NavigationToPage = "Profile"
                },

                new BookModel(){
                        Image = "book_02.png",
                        NavigationToPage = "Profile"
                },

                new BookModel(){
                        Image = "book_03.png",
                        NavigationToPage = "Profile"
                }
            };
        }

        private void StartBooksMoreRead()
        {
            _booksBooksMoreRead = new List<BookModel>()
            {
                new BookModel(){
                        Image = "book_04.png",
                        NavigationToPage = "Profile"
                },

                new BookModel(){
                        Image = "book_05.png",
                        NavigationToPage = "Profile"
                },

                new BookModel(){
                        Image = "book_06.png",
                        NavigationToPage = "Profile"
                }
            };
        }

        private void StartBooksBestRated()
        {
            _booksBestRated = new List<BookModel>()
            {
                new BookModel(){
                        Image = "book_07.png",
                        NavigationToPage = "Profile"
                },

                new BookModel(){
                        Image = "book_08.png",
                        NavigationToPage = "Profile"
                },

                new BookModel(){
                        Image = "book_09.png",
                        NavigationToPage = "Profile"
                }
            };
        }

        private void StartBooksRecommended()
        {
            _booksRecommended = new List<BookModel>()
            {
                new BookModel(){
                        Image = "book_01.png",
                        NavigationToPage = "Profile"
                },

                new BookModel(){
                        Image = "book_03.png",
                        NavigationToPage = "Profile"
                },

                new BookModel(){
                        Image = "book_05.png",
                        NavigationToPage = "Profile"
                },

                new BookModel(){
                        Image = "book_07.png",
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
