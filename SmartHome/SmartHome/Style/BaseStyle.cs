using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartHome
{
    public class BaseStyle : Page
    {
        /// <summary>
        /// 按钮样式
        /// </summary>
        public static Style buttonStyle = new Style(typeof(Button))
        {
            Setters =
                {
                    new Setter {Property = BackgroundColorProperty, Value = Color.Transparent},
                    new Setter {Property = HeightRequestProperty, Value = 80},
                    new Setter {Property = Button.BorderWidthProperty, Value = 1},
                    new Setter {Property = Button.BorderColorProperty, Value = Color.White},
                    new Setter {Property = Button.TextColorProperty, Value = Color.White},
                }
        };

        public static Style entryStyle = new Style(typeof(Entry))
        {
            Setters =
                {
                    new Setter {Property = BackgroundColorProperty, Value = Color.Transparent},
                    new Setter {Property = HeightRequestProperty, Value = 80},
                    new Setter {Property = Entry.TextColorProperty, Value = Color.White},
                }
        };

        public static Style lableStyle = new Style(typeof(Label))
        {
            Setters =
                {
                    new Setter {Property = BackgroundColorProperty, Value = Color.Transparent},
                    new Setter {Property = HeightRequestProperty, Value = 80},
                    new Setter {Property = WidthRequestProperty, Value = 120},
                    new Setter {Property = Label.TextColorProperty, Value = Color.White},
                }
        };
    }
}
