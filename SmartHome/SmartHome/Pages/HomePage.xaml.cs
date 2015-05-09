using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHome.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            InitEvent();
            LoadInfo();
        }

        private void InitEvent()
        {
            //网关
            var tgr_W0103 = new TapGestureRecognizer();
            tgr_W0103.Tapped += (s, e) =>
            {
                DisplayAlert("提示", "你选择了网关", "OK");
            };
            CU_W0103.GestureRecognizers.Add(tgr_W0103);

            //触摸开关
            var tgr_K0203 = new TapGestureRecognizer();
            tgr_K0203.Tapped += (s, e) =>
            {
                DisplayAlert("提示", "你选择了触摸开关", "OK");
            };
            CU_K0203.GestureRecognizers.Add(tgr_K0203);

            //门窗磁
            var tgr_A0501 = new TapGestureRecognizer();
            tgr_A0501.Tapped += (s, e) =>
            {
                DisplayAlert("提示", "你选择了门窗磁", "OK");
            };
            CU_A0501.GestureRecognizers.Add(tgr_A0501);

            //红外感应器
            var tgr_A0541 = new TapGestureRecognizer();
            tgr_A0541.Tapped += (s, e) =>
            {
                DisplayAlert("提示", "你选择了红外感应器", "OK");
            };
            CU_A0541.GestureRecognizers.Add(tgr_A0541);

            //调色控制器
            var tgr_C0611 = new TapGestureRecognizer();
            tgr_C0611.Tapped += (s, e) =>
            {
                DisplayAlert("提示", "你选择了调色控制器", "OK");
            };
            CU_C0611.GestureRecognizers.Add(tgr_C0611);

            //智能继电器
            var tgr_K0221 = new TapGestureRecognizer();
            tgr_K0221.Tapped += (s, e) =>
            {
                DisplayAlert("提示", "你选择了智能继电器", "OK");
            };
            CU_K0221.GestureRecognizers.Add(tgr_K0221);

            //菜单设置
            var tgr_setting1 = new TapGestureRecognizer();
            tgr_setting1.Tapped += (s, e) =>
            {
                NavigationTab(TabMenus.TabMore);
            };
            menu_setting.GestureRecognizers.Add(tgr_setting1);

            //报警设置
            var tgr_message = new TapGestureRecognizer();
            tgr_message.Tapped += async (s, e) =>
            {
                NavigationTab(TabMenus.TabMesssage);
            };
            menu_message.GestureRecognizers.Add(tgr_message);
            message_info.GestureRecognizers.Add(tgr_message);


            //菜单设置
            var tgr_gateway = new TapGestureRecognizer();
            tgr_gateway.Tapped += (s, e) =>
            {
                Navigation.PushModalAsync(new GatewayManagePage());
            };
            select_gateway.GestureRecognizers.Add(tgr_gateway);

           

        }

        private void LoadInfo()
        {
            switch (Wswl.CurrentGateway)
            {
                case 1: this.gatewayName.Text = "无声物联办公室"; break;
                case 2: this.gatewayName.Text = "Arlen家"; break;
                default: this.gatewayName.Text = "你猜我是哪儿的网关"; break;
            }
        }

        private void NavigationTab(WswlMenu menu)
        {
            var tp = this.Parent as MainPage;
            if (tp != null) tp.NavigationCurrentPage(menu);
        }
    }
}
