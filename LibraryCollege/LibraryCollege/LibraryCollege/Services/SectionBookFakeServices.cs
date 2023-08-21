using LibraryCollege.Enums;
using LibraryCollege.Interfaces;
using LibraryCollege.Models;
using LibraryCollege.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;

[assembly: Dependency(typeof(SectionBookFakeServices))]
namespace LibraryCollege.Services
{
    public class SectionBookFakeServices : ISectionBookFakeService
    {
        private List<BookModel> books;

        public SectionBookFakeServices() {
            Setup();
        }

        private void Setup()
        {
            books = new List<BookModel>()
            {
                new BookModel(){
                        Image = "book_01.png",
                        NavigationToPage = "Profile",
                        BookFlag = BookFlag.AVAILABLE
                },

                new BookModel(){
                        Image = "book_02.png",
                        NavigationToPage = "Profile",
                        BookFlag = BookFlag.AVAILABLE
                },

                new BookModel(){
                        Image = "book_03.png",
                        NavigationToPage = "Profile",
                        BookFlag = BookFlag.AVAILABLE
                },

                new BookModel(){
                        Image = "book_04.png",
                        NavigationToPage = "Profile",
                        BookFlag = BookFlag.MORE_READ
                },

                new BookModel(){
                        Image = "book_05.png",
                        NavigationToPage = "Profile",
                        BookFlag = BookFlag.MORE_READ
                },

                new BookModel(){
                        Image = "book_06.png",
                        NavigationToPage = "Profile",
                        BookFlag = BookFlag.MORE_READ
                },

                new BookModel(){
                        Image = "book_07.png",
                        NavigationToPage = "Profile",
                        BookFlag = BookFlag.BEST_RATED
                },

                new BookModel(){
                        Image = "book_08.png",
                        NavigationToPage = "Profile",
                        BookFlag = BookFlag.BEST_RATED
                },

                new BookModel(){
                        Image = "book_09.png",
                        NavigationToPage = "Profile",
                        BookFlag = BookFlag.BEST_RATED
                },

                new BookModel(){
                        Image = "book_01.png",
                        NavigationToPage = "Profile",
                        BookFlag = BookFlag.RECOMMENDED
                },

                new BookModel(){
                        Image = "book_03.png",
                        NavigationToPage = "Profile",
                        BookFlag = BookFlag.RECOMMENDED
                },

                new BookModel(){
                        Image = "book_05.png",
                        NavigationToPage = "Profile",
                        BookFlag = BookFlag.RECOMMENDED
                },

                new BookModel(){
                        Image = "book_07.png",
                        NavigationToPage = "Profile",
                        BookFlag= BookFlag.RECOMMENDED
                },



            };
        }

        public List<BookModel> GetBooksAvaliable()
        {
            return SeekBookByFlag(BookFlag.AVAILABLE);
        }

        public List<BookModel> GetBooksMoreRead()
        {
            return SeekBookByFlag(BookFlag.MORE_READ);            
        }

        public List<BookModel> GetBooksBestRated()
        {
            return SeekBookByFlag(BookFlag.BEST_RATED);
        }

        public List<BookModel> GetBooksRecommended()
        {
            return SeekBookByFlag(BookFlag.RECOMMENDED);
        }

        private List<BookModel> SeekBookByFlag(BookFlag flag)
        {
            var result = books
                        .Where(book => book.BookFlag == flag)
                        .ToList();

            return result;
        }
    }
}
