﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHome.Pages
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {

            InitializeComponent();
            this.btnAdd.Clicked += (s, e) =>
            {
               Navigation.PushModalAsync(new LoginPage());
            };
        }


    }
}
