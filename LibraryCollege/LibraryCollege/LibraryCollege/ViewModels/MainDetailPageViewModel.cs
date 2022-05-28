using LibraryCollege.Interfaces;
using LibraryCollege.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace LibraryCollege.ViewModels
{
    public class MainDetailPageViewModel : BindableBase
    {
        //private readonly INavigationService _navigationService;
        IBookFakeService _bookFakeService;

        public IReadOnlyCollection<BookModel> Books
        {
            get { return _bookFakeService.GetBooks(); }
        }
        public MainDetailPageViewModel()
        {
            //_navigationService = navigationService;
            _bookFakeService = DependencyService.Get<IBookFakeService>();
        }
    }
}
