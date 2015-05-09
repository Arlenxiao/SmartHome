using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHome.Pages
{
    public partial class MorePage : ContentPage
    {
        public MorePage()
        {
            InitializeComponent();
            InitEvent();
        }


        private void InitEvent()
        {
            var tgr_setting = new TapGestureRecognizer();
            tgr_setting.Tapped += (s, e) =>
            {
                Navigation.PushModalAsync(new SystemSettingPage());
            };
            setting_system.GestureRecognizers.Add(tgr_setting);
            setting_account.GestureRecognizers.Add(tgr_setting);
            setting_gateway.GestureRecognizers.Add(tgr_setting);
            setting_shop.GestureRecognizers.Add(tgr_setting);
        }
    }
}
