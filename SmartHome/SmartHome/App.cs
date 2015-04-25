using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartHome.Pages;
using Xamarin.Forms;

namespace SmartHome
{
    public partial class App : Application, IPageManager
    {
        public App()
        {
            // The root page of your application
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private void ShowLogin()
        {
            if (!((NavigationPage)MainPage).CurrentPage.GetType().Equals(typeof(LoginPage)))
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    MainPage.Navigation.PushModalAsync(new LoginPage());
                });
            }
        }


        public void NavigationPage(Page page)
        {
            MainPage = page;
        }
    }
}
