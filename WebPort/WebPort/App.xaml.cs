﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace WebPort
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //   MainPage = new WebPort.MainPage(); //to be fixed 
            //https://forums.xamarin.com/discussion/18385/pushasync-is-not-supported-globally-on-ios-please-use-a-navigationpage

            var nav = new NavigationPage(new MainPage());
            MainPage = nav;
        }

        //control local vs online webpages
        public static bool isOnline = true;
        public static bool isSettingsOnline = false;

        public static string webURL = "http://winecouncilofontario.ca/";

        //ToDo: Implement local file support
        //https://developer.xamarin.com/guides/xamarin-forms/user-interface/webview/
        public static string localURL = "";

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
