using LibraryCollege.Interfaces;
using LibraryCollege.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xamarin.Forms;

namespace LibraryCollege.ViewModels
{
	public class SectionBooksSelectedPageViewModel : BindableBase, INavigatedAware
	{
        private readonly INavigationService _navigationService;
        private IReadOnlyCollection<BookModel> _books;
        private string _section;

        public string Section
        {
            get { return _section; }
            private set { SetProperty(ref _section, value); }
        }
        public IReadOnlyCollection<BookModel> Books
        {
            get { return _books; }
            set { SetProperty(ref _books, value); }
        }

        public SectionBooksSelectedPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;            
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            Section = parameters.GetValue<string>("Section");
            var examplePar = parameters.GetValues<IReadOnlyCollection<BookModel>>("BookSection");
            foreach (var book in examplePar)
            {
                Books = book;
            }
        }
    }
}
