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

            this.lbl_info.Text = "Sometimes page content fits entirely on " +
                                 "the page. That's very convenient. But " +
                                 "on many occasions, the content of the page " +
                                 "is much too large for the page, or only " +
                                 "becomes available at runtime." +
                                 "\n\n" +
                                 "For cases such as these, the ScrollView " +
                                 "provides a solution. Simply set its " +
                                 "Content property to your content \u2014 in this " +
                                 "case a Label but in the general case very " +
                                 "likely a Layout derivative with multiple " +
                                 "children \u2014 and the ScrollView provides " +
                                 "scrolling with the distinctive look and touch " +
                                 "familiar to the user." +
                                 "\n\n" +
                                 "The ScrollView is also capable of " +
                                 "horizontal scrolling, and while that's " +
                                 "usually not as common as vertical scrolling, " +
                                 "sometimes it comes in handy." ;


            this.lbl_info.FontSize = Device.GetNamedSize(NamedSize.Large, typeof (Label));
            this.lbl_info_1.Text = "Sometimes page content fits entirely on " +
                               "the page. That's very convenient. But " +
                               "on many occasions, the content of the page " +
                               "is much too large for the page, or only " +
                               "becomes available at runtime." +
                               "\n\n" +
                               "For cases such as these, the ScrollView " +
                               "provides a solution. Simply set its " +
                               "Content property to your content \u2014 in this " +
                               "case a Label but in the general case very " +
                               "likely a Layout derivative with multiple " +
                               "children \u2014 and the ScrollView provides " +
                               "scrolling with the distinctive look and touch " +
                               "familiar to the user." +
                               "\n\n" +
                               "The ScrollView is also capable of " +
                               "horizontal scrolling, and while that's " +
                               "usually not as common as vertical scrolling, " +
                               "sometimes it comes in handy.";


            this.lbl_info_1.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));


        }
    }
}
