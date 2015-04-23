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
            this.NeedShowBusy = true;
            //登录逻辑
            var islogin = !NeedShowBusy;

            this.NeedShowBusy = false;
            if (islogin)
            {
                await this.DisplayAlert("警告", "认证失败,请确认您的账户和密码是否正确", "OK");
            }
            else
            {
                //await this.Navigation.PopModalAsync();
            }
        }

    }
}
