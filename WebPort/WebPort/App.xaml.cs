using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace WebPort
{
    public partial class App : Application
    {
        public static bool isOnline = false; // true
        public static bool isSettingsOnline = false;

        public static string webURL = "https://www.ptlevel.com/secure/";
        public static string aboutURL = "https://www.ptlevel.com/secure/";
        public App()
        {
            InitializeComponent();
            var nav = new NavigationPage(new MainPage());
            MainPage = nav;
        }
    }
}
