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
        }

        public async void Login(object sender, EventArgs e)
        {
            await this.DisplayAlert("警告", "账号:"+this.account.Text+" 密码"+this.password.Text, "OK");
        }

        public async void Register(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new RegisterPage());
        }
    }
}
