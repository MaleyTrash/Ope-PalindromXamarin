﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xam
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            new Palindrom(MainInput, DisplayLabel);
        }
    }
}
