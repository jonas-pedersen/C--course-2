﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FF1Jonas
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyTextBox.Text = "Nu tryckte du på knappen!";
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            MyButton.IsEnabled = false;
        }

    

        private void Checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            MyButton.IsEnabled = true;
        }

        private void Checkbox_Click(object sender, RoutedEventArgs e)
        {
            MyButton.IsEnabled = (bool)MyCheckBox.IsChecked;
        }
    }
}
