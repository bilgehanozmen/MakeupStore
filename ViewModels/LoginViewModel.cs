using MakeupStore.Models;
using MakeupStore.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MakeupStore.ViewModels
{
    public class LoginViewModel
    {
        private string _username, _password;

        public string UserName { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }

        public ICommand RegisterCommand { private get; set; }

        public ICommand LoginCommand { private get; set; }

        private INavigation Navigation;
        public LoginViewModel(INavigation navigation) 
        {
            RegisterCommand = new Command(OnRegisterCommand);
            LoginCommand = new Command(OnLoginCommand);
            Navigation = navigation;

        }
        private async void OnLoginCommand(object obj)
        {
            var loginData = await Profile.Database.GetLoginDataAsync(UserName);
            if (loginData != null)
            {
                if (string.Equals(loginData.Password, Password))
                {
                    await Navigation.PushModalAsync(new Home());
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("failure", "Invalid Username", "Ok");
                }
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("failure", "Invalid Username", "Ok");
            }

        }
        private void OnRegisterCommand(object obj)
        {
            LoginModel lm = new LoginModel();
            lm.UserName = UserName;
            lm.Password = Password;
            Profile.Database.SaveLoginDataAsync(lm);
            App.Current.MainPage.DisplayAlert("Success", "Registration uccessful", "Ok");

        }
    }
}
