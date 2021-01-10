using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Absencia.Views;

namespace Absencia.ViewModels
{
    class RegisterViewModel : BaseViewModel
    {
        public Command Login { get; }
        public Command Register { get; }
        

        public RegisterViewModel()
        {
            Login = new Command(OnLoginClicked);
            Register = new Command(OnRegisterClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
        private async void OnRegisterClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
