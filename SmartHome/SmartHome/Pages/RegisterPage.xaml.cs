using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHome.Pages
{
    public partial class RegisterPage : ContentPage
    {

        public String UserName { get; set; }
        public String Password { get; set; }
        public String ConfirmPassword { get; set; }

        public RegisterPage()
        {
            InitializeComponent();
            //backgroundImage.Source = ImageSource.FromFile(Common.BackgroundImage);

            btn_register.Clicked += (s, e) =>
            {
                var text = string.Format("用户名:{0} 密码:{1} 确认密码:{2}", userName.Text, password.Text, confirmPassword.Text);
                DisplayAlert("提示", text, "OK");

            };

            btn_back.Clicked += (s, e) =>
            {
                Navigation.PushModalAsync(new LoginPage());
            };
        }
    }
}
