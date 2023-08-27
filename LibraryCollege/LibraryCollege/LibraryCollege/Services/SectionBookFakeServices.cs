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
                        Title = "The Lion the Witch and the wardrobe",
                        Author = "C.S Lewis",
                        BookFlag = BookFlag.AVAILABLE
                },

                new BookModel(){
                        Image = "book_02.png",
                        Title = "The Voyage of the Dawn Treader",
                        Author = "C.S Lewis",
                        BookFlag = BookFlag.AVAILABLE
                },

                new BookModel(){
                        Image = "book_03.png",
                        Title = "The Lord of the rings Part 1",
                        Author = "J.R,R Tolkien",
                        BookFlag = BookFlag.AVAILABLE
                },

                new BookModel(){
                        Image = "book_04.png",
                        Title = "I Belong Here",
                        Author = "",
                        BookFlag = BookFlag.MORE_READ
                },

                new BookModel(){
                        Image = "book_05.png",
                        Title = "A Woman of War",
                        Author = "Mandy Robotham",
                        BookFlag = BookFlag.MORE_READ
                },

                new BookModel(){
                        Image = "book_06.png",
                        Title = "Coffee Self-Talk",
                        Author = "Kristen Helmstetter",
                        BookFlag = BookFlag.MORE_READ
                },

                new BookModel(){
                        Image = "book_07.png",
                        Title = "Midnight at the Blackbird Cafe",
                        Author = "Heather Webber",
                        BookFlag = BookFlag.BEST_RATED
                },

                new BookModel(){
                        Image = "book_08.png",
                        Title = "The Shack",
                        Author = "William P. Young",
                        BookFlag = BookFlag.BEST_RATED
                },

                new BookModel(){
                        Image = "book_09.png",
                        Title = "Mrs England",
                        Author = "Stacey Halls",
                        BookFlag = BookFlag.BEST_RATED
                },

                new BookModel(){
                        Image = "book_01.png",
                        Title = "The Lion the Witch and the wardrobe",
                        Author = "C.S Lewis",
                        BookFlag = BookFlag.RECOMMENDED
                },

                new BookModel(){
                        Image = "book_03.png",
                        Title = "The Lord of the rings Part 1",
                        Author = "J.R,R Tolkien",
                        BookFlag = BookFlag.RECOMMENDED
                },

                new BookModel(){
                        Image = "book_05.png",
                        Title = "A Woman of War",
                        Author = "Mandy Robotham",
                        BookFlag = BookFlag.RECOMMENDED
                },

                new BookModel(){
                        Image = "book_07.png",
                        Title = "Midnight at the Blackbird Cafe",
                        Author = "Heather Webber",
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
