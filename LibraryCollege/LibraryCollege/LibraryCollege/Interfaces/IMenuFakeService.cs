using LibraryCollege.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCollege.Interfaces
{
    public interface IMenuFakeService
    {
        List<MenuModel> GetMenus();
    }
}
