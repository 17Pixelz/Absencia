using Absencia.Views;
using Plugin.Toast;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Absencia.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public String Name { get; set; }

        public Command Register { get; }
        

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            Register = new Command(OnRegisterClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            if (Name == "youssef")
                await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
            else
                CrossToastPopUp.Current.ShowToastMessage("Ops! Wrong <)");
        }
        private async void OnRegisterClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(RegisterPage)}");
  
        }
    }
}
