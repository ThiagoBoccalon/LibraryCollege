using LibraryCollege.Interfaces;
using LibraryCollege.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace LibraryCollege.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;
        ISectionBookFakeService _bookFakeService;

        public IReadOnlyCollection<BookModel> BooksAvaliablesToYou
        {
            get { return _bookFakeService.GetBooksAvaliableToYou(); }
        }

        public IReadOnlyCollection<BookModel> BooksMoreRead
        {
            get { return _bookFakeService.GetBooksMoreRead(); }
        }

        public IReadOnlyCollection<BookModel> BooksBestRated
        {
            get { return _bookFakeService.GetBooksBestRated(); }
        }

        public IReadOnlyCollection<BookModel> BooksRecommended
        {
            get { return _bookFakeService.GetBooksRecommended(); }
        }

        public ICommand ExecuteNavigationToProfile { get; set; }
        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            _bookFakeService = DependencyService.Get<ISectionBookFakeService>();
            ExecuteNavigationToProfile = new Command(() => ExecuteToProfile());
        }

        private void ExecuteToProfile()
        {
            _navigationService.NavigateAsync("ProfilePage");
        }
    }
}
