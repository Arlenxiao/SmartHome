using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHome.Pages
{
    public partial class ProductsListPage : ContentPage
    {
        public ProductsListPage()
        {
            InitializeComponent();
            InitEvent();
        }


        private void InitEvent()
        {
            var tgr_detail = new TapGestureRecognizer();
            tgr_detail.Tapped += (s, e) =>
            {
                Navigation.PushModalAsync(new SystemSettingPage());
            };
            CU_W0103.GestureRecognizers.Add(tgr_detail);
            CU_K0203.GestureRecognizers.Add(tgr_detail);
            CU_K0221.GestureRecognizers.Add(tgr_detail);
            CU_C0611.GestureRecognizers.Add(tgr_detail);
            CU_A0501.GestureRecognizers.Add(tgr_detail);
            CU_A0541.GestureRecognizers.Add(tgr_detail);
        }
    }
}
