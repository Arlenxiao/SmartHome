﻿using System;
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
            backgroundImage.Source = ImageSource.FromFile(Common.BackgroundImage);
        }
    }
}
