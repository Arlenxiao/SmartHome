using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHome.Pages
{
    public partial class MessagePage : ContentPage
    {
        public MessagePage()
        {
            InitializeComponent();
            InitEvent();
        }

        private void InitEvent()
        {
            var tgr_info = new TapGestureRecognizer();
            tgr_info.Tapped += (s, e) =>
            {
                Navigation.PushModalAsync(new MessageDetailPage());
            };
            info_0.GestureRecognizers.Add(tgr_info);
            info_1.GestureRecognizers.Add(tgr_info);
            info_2.GestureRecognizers.Add(tgr_info); 
            info_3.GestureRecognizers.Add(tgr_info);
            info_4.GestureRecognizers.Add(tgr_info);
            info_5.GestureRecognizers.Add(tgr_info);
            info_6.GestureRecognizers.Add(tgr_info);
            info_7.GestureRecognizers.Add(tgr_info);
            info_8.GestureRecognizers.Add(tgr_info);
        }

    }
}
