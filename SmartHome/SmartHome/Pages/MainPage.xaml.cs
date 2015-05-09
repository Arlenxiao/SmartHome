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
            InitTabPages();
        }

        private Page _tabHome;
        private Page _tabMessage;
        private Page _tabProducts;
        private Page _tabMore;

        private void InitTabPages()
        {
            _tabHome = new HomePage { Title = TabMenus.TabHome.Title, Icon = TabMenus.TabHome.Icon };
            _tabMessage = new MessagePage { Title = TabMenus.TabMesssage.Title, Icon = TabMenus.TabMesssage.Icon };
            _tabProducts = new ProductsListPage { Title = TabMenus.TabProducts.Title, Icon = TabMenus.TabProducts.Icon };
            _tabMore = new MorePage { Title = TabMenus.TabMore.Title, Icon = TabMenus.TabMore.Icon };

            Children.Add(_tabHome);
            Children.Add(_tabMessage);
            Children.Add(_tabProducts);
            Children.Add(_tabMore);
        }


        public void NavigationCurrentPage(WswlMenu menu)
        {
            switch (menu.Index)
            {
                case 0: CurrentPage = _tabHome; break;
                case 1: CurrentPage = _tabMessage; break;
                case 2: CurrentPage = _tabProducts; break;
                case 3: CurrentPage = _tabMore; break;
                default:
                    CurrentPage = _tabHome; break;
            }
        }
    }
}
