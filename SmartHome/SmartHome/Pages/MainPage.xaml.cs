using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHome.Pages
{
    public partial class MainPage : TabbedPage
    {

        public MainPage()
        {

            InitializeComponent();

            this.Children.Add(new HomePage()
            {
                Title = "主页",
                Icon = "home.png",
            });
            this.Children.Add(new MessagePage() { Title = "信息", Icon = "message.png", });
            this.Children.Add(new ProductsListPage() { Title = "设备", Icon = "products.png", });
            this.Children.Add(new MorePage() { Title = "更多", Icon = "more.png", });
            
        }


    }
}
