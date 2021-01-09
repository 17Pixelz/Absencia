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
        private string err;
        public String Err {
            get
            {
                return err;
            }
            set
            {
                err = value;
                OnPropertyChanged(nameof(err)); 
            }
        }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            if (Name == "youssef")
                await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
            else
                CrossToastPopUp.Current.ShowToastMessage("Ops! Wrong <)");
        }
    }
}
