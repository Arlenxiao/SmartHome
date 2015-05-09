using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHome.Pages
{
    public partial class GatewayManagePage : ContentPage
    {
        public GatewayManagePage()
        {
            InitializeComponent();
            InitEvent();
        }

        private void InitEvent()
        {
            //网关
            var tgr_W0001 = new TapGestureRecognizer();
            tgr_W0001.Tapped += (s, e) =>
            {
                Wswl.CurrentGateway = 1;
                //DisplayAlert("提示", "你选择了网关1", "OK");
                Navigation.PushModalAsync(new MainPage());
            };
            W0001.GestureRecognizers.Add(tgr_W0001);

            //网关
            var tgr_W0002 = new TapGestureRecognizer();
            tgr_W0002.Tapped += (s, e) =>
            {
                Wswl.CurrentGateway = 2;
                //DisplayAlert("提示", "你选择了网关2", "OK");
                Navigation.PushModalAsync(new MainPage());
            };
            W0002.GestureRecognizers.Add(tgr_W0002);
        }
    }
}
