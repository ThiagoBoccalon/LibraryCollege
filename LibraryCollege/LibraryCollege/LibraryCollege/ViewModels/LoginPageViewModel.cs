using LibraryCollege.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LibraryCollege.ViewModels
{
    public class LoginPageViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private readonly string usernameToValidation = "Thiago";
        private readonly string passwordToValidation = "123";

        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService _navigationService;

        private string _username;
        public string UserName
        {
            get { return _username; }
            set
            {
                _username = value;
                PropertyChanged(this, new PropertyChangedEventArgs("UserName"));
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public ICommand ExecuteLogin { get; set; }
        public LoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {    
           _navigationService = navigationService;
           Title = "Login";           
           ExecuteLogin = new Command(() => Login());                      
        }
        
        private void Login()
        {
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
                App.Current.MainPage.DisplayAlert("Empty values", "Plese enter Username and Password", "OK");

            if(usernameToValidation.Equals(UserName) && passwordToValidation.Equals(Password))
            {
                //Application.Current.MainPage = new MainPage(); 
                _navigationService.NavigateAsync("/MainMasterPage/NavigationPage/MainDetailPage");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Empty values", "Plese enter Username and Password valid", "OK");
            }
        }
    }
}
