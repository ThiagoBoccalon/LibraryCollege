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
    public class MainDetailPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;
        IBookFakeService _bookFakeService;

        public IReadOnlyCollection<BookModel> Books
        {
            get { return _bookFakeService.GetBooks(); }
        }

        public ICommand ExecuteNavigationToProfile { get; set; }
        public MainDetailPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            _bookFakeService = DependencyService.Get<IBookFakeService>();
            ExecuteNavigationToProfile = new Command(() => ExecuteToProfile());
        }

        private void ExecuteToProfile()
        {
            _navigationService.NavigateAsync("ProfilePage");
        }
    }
}
