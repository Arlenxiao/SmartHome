using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class TabMenus
    {
        public static WswlMenu TabHome = new WswlMenu() { Index = 0, Title = "主页", Icon = "home.png" };
        public static WswlMenu TabMesssage = new WswlMenu() { Index = 1, Title = "信息", Icon = "message.png" };
        public static WswlMenu TabProducts = new WswlMenu() { Index = 2, Title = "设备", Icon = "products.png" };
        public static WswlMenu TabMore = new WswlMenu() { Index = 3, Title = "更多", Icon = "more.png" };

    }

    public class WswlMenu
    {
        public Int32 Index { get; set; }
        public String Title { get; set; }
        public String Icon { get; set; }


    }
}
