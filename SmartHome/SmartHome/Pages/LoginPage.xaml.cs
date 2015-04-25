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


        public LoginPage()
        {
            InitializeComponent();
            //this.account.Style = BaseStyle.entryStyle;
            //this.password.Style = BaseStyle.entryStyle;
        }

        public async void Login(object sender, EventArgs e)
        {

            var user = this.account.Text;
            var pwd = this.password.Text;
            if (user == "1" && pwd == "1")
            {
                await this.Navigation.PushModalAsync(new MainPage());
            }
            else
            {
                await this.DisplayAlert("警告", "账号:" + user + " 密码:" + pwd , "OK");
            }
        }

        public async void Register(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new RegisterPage());
        }
    }
}
