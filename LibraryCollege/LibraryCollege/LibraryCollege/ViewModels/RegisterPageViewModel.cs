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
    public class RegisterPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;

        public ICommand ExecuteSingUp { get; set; }
        public RegisterPageViewModel(INavigationService navigationPage)
        {
            _navigationService = navigationPage;
            ExecuteSingUp = new Command(() => SingUp());
        }

        private void SingUp()
        {
            if(IsValidationData())
                _navigationService.GoBackAsync(useModalNavigation: true);                
        }

        private bool IsValidationData()
        {
            /*TO DO*/
            return true;
        }
    }
}
