using LibraryCollege.Interfaces;
using LibraryCollege.Models;
using LibraryCollege.Services;
using MvvmHelpers.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LibraryCollege.ViewModels
{
    public class MainMasterPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;
        IMenuFakeService _menuFakeService;

        public IReadOnlyCollection<MenuModel> Menus
        {            
            get { return _menuFakeService.GetMenus(); }            
        }

        private MenuModel _selectedMenus { get; set; }
        public MenuModel SelectedMenus
        {
            get { return _selectedMenus; }
            set { _selectedMenus = value; HandleSelectedItemAsync(); }
        }

        private async Task HandleSelectedItemAsync()
        {
            await _navigationService.NavigateAsync("MainDetailPage/NavigationPage/" + SelectedMenus.NavigationTo);
        }
        public ICommand ExecuteNavigationToProfile { get; set; }
        
        public MainMasterPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;            
            _menuFakeService = DependencyService.Get<IMenuFakeService>();            
        }
    }
}
