using LibraryCollege.Interfaces;
using LibraryCollege.Models;
using LibraryCollege.Services;
using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.Generic;
using System.ComponentModel;
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
        
        public ICommand ExecuteNavigationToProfile {  set; get; }
        public ICommand ExecuteNavigationToHistory { set; get; }        
        public ICommand ExecuteNavigationToLogOut { set; get; }

        public MainMasterPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;            
            ExecuteNavigationToProfile = new Command(() => ExecuteToProfile());
            _menuFakeService = DependencyService.Get<IMenuFakeService>();
        }

        public void ExecuteToProfile()
        {
            _navigationService.NavigateAsync("ProfilePage");
        }
    }
}
