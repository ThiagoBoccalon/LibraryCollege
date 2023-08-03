using LibraryCollege.Interfaces;
using LibraryCollege.Models;
using LibraryCollege.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

[assembly:Dependency(typeof(MenuFakeService))]
namespace LibraryCollege.Services
{
    public class MenuFakeService : IMenuFakeService
    {        
        private List<MenuModel> _menus;
                
        private void StartMenus()
        {
            _menus = new List<MenuModel>()
            {
                new MenuModel(){Icon= "icons_home_100.png", Title = "HOME", NavigationTo= ""},
                new MenuModel(){ Icon = "icons_female_profile_100.png", Title = "PROFILE", NavigationTo = "ProfilePage" },
                new MenuModel() { Icon = "icons_books_100.png", Title = "HISTORY", NavigationTo = "" },
                new MenuModel() { Icon = "icons_logout_100.png", Title = "LOG OUT", NavigationTo = "" }
            };
        }

        public List<MenuModel> GetMenus()
        {
            StartMenus();
            return _menus;
        }

    }
}
