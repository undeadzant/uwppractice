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

namespace tagur
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            // adding in parts from tutorial here
            this.Loaded += MainPage_Loaded;
            this.mainFrame.Navigated += MainFrame_Navigated;
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            backButton.IsEnabled = mainFrame.CanGoBack;
            forwardButton.IsEnabled = mainFrame.CanGoForward;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(Pages.Page1));
        }

        private void OnGoBackClick(object sender, RoutedEventArgs e)
        {
            if (mainFrame.CanGoBack) mainFrame.GoBack();
        }

        private void OnGoForwardClick(object sender, RoutedEventArgs e)
        {
            if (mainFrame.CanGoForward) mainFrame.GoForward();
        }

        private void OnGoPage1Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(Pages.Page1));
        }

        private void OnGoPage2Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(Pages.Page2));
        }

        private void OnGoPage3Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(typeof(Pages.Page3));
        }
    }
}
