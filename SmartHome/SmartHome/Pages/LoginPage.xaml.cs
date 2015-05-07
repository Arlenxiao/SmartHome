using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHome.Pages
{
    public partial class LoginPage : ContentPage
    {

        public string Account { get; set; }

        public string Password { get; set; }

        public bool NeedShowBusy { get; set; }

        //private IPageManager PM { get; set; }


        public LoginPage()
        {
            InitializeComponent();
            //this.backgroundImage.Source = ImageSource.FromFile(Common.BackgroundImage);
            InitEvent();
        }

        private void InitEvent()
        {

            var tgr_register = new TapGestureRecognizer();
            tgr_register.Tapped += (s, e) =>
            {
                Navigation.PushModalAsync(new RegisterPage()); 
            };
            this.register.GestureRecognizers.Add(tgr_register);

            var tgr_wswl = new TapGestureRecognizer();
            tgr_wswl.Tapped += (s, e) =>
            {
                Device.OpenUri(new Uri("http://www.peacemoon.cn/"));
            };
            this.wswl.GestureRecognizers.Add(tgr_wswl);
        }

        public async void Login(object sender, EventArgs e)
        {

            var user = this.account.Text;
            var pwd = this.password.Text;
            //if (user == "1" && pwd == "1")
            //{
                await Navigation.PushModalAsync(new MainPage());
            //}
            //else
            //{
            //    await this.DisplayAlert("警告", "账号:" + user + " 密码:" + pwd , "OK");
            //}
        }

    }
}
