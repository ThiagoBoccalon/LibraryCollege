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
                new MenuModel(){ Icon = "icon_profile.png", Title = "PROFILE" },
                new MenuModel() { Icon = "icon_history.png", Title = "HISTORY" },
                new MenuModel() { Icon = "icon_logout.png", Title = "LOG OUT" }
            };
        }

        public List<MenuModel> GetMenus()
        {
            StartMenus();
            return _menus;
        }

    }
}
