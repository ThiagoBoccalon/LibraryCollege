using LibraryCollege.Enums;
using LibraryCollege.Interfaces;
using LibraryCollege.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace LibraryCollege.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        const string AVAILABLE = "AVAILABLE";
        const string MOREREAD = "MORE_READ";
        const string BESTRATED = "BEST_RATED";
        const string RECOMMENDED = "RECOMMENDED";

        private readonly INavigationService _navigationService;
        ISectionBookFakeService _bookFakeService;

        IReadOnlyCollection<BookModel> _books;

        public IReadOnlyCollection<BookModel> BooksAvaliablesToYou
        {
            get
            {
                return _bookFakeService.GetBooksAvaliable();
            }            
        }

        public IReadOnlyCollection<BookModel> BooksMoreRead
        {
            get 
            {
                _books = _bookFakeService.GetBooksMoreRead();
                return _books; 
            }
        }

        public IReadOnlyCollection<BookModel> BooksBestRated
        {
            get 
            { 
                _books = _bookFakeService.GetBooksBestRated();
                return _books; 
            }
        }

        public IReadOnlyCollection<BookModel> BooksRecommended
        {
            get 
            { 
                _books = _bookFakeService.GetBooksRecommended();
                return _books; 
            }
        }

        public ICommand ExecuteNavigationToProfile { get; set; }

        public ICommand ExecuteNavigationToSectionBooks { get; set; }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            _bookFakeService = DependencyService.Get<ISectionBookFakeService>();
            ExecuteNavigationToProfile = new Command(() => ExecuteToProfile());
            ExecuteNavigationToSectionBooks = new Command(ExecuteToSectionBooks);
        }

        private async void ExecuteToProfile()
        {
            await _navigationService.NavigateAsync("ProfilePage");
        }

        private async void ExecuteToSectionBooks(object parameter)
        {
            var booksParameter = new NavigationParameters();
            IReadOnlyCollection<BookModel> booksThisSection = null;

            switch (parameter) 
            {
                case AVAILABLE:
                    {
                        booksThisSection = BooksAvaliablesToYou;
                        break;
                    }
                case MOREREAD:
                    {
                        booksThisSection = BooksMoreRead;
                        break;
                    }
                case BESTRATED:
                    {
                        booksThisSection = BooksBestRated;
                        break;
                    }
                case RECOMMENDED:
                    {
                        booksThisSection = BooksRecommended;
                        break;
                    }
            }
            
            booksParameter.Add("BookSection", booksThisSection);
            await _navigationService.NavigateAsync("SectionBooksSelectedPage", booksParameter);
        }
    }
}
