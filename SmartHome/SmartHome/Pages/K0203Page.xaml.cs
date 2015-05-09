using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHome.Pages
{
    public partial class K0203Page : ContentPage
    {
        public K0203Page()
        {
            InitializeComponent();
        }

        public K0203Page(Page p):this()
        {
            MP = p;
        }

        private Page MP;
        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}
