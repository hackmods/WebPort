using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WebPort
{
    public partial class AboutPage : ContentPage
    {
        string webURL = "";
        string localURL = "";

        public AboutPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);

            if (App.isSettingsOnline)
            {
                webURL = App.webURL + "about/";
                MyWeb.Source = webURL;
            }
            else
            {
                //   localURL = App.localURL;
                var htmlSource = new HtmlWebViewSource();
                htmlSource.Html = @"<html>
                            <head>
                             <style>
                            body {background-color: #E7E7E7;}
                            h1   {color: #455372; text-align: center;}
                            p    {color: #616A7F; text-align: center;}
                            .ser {
                                font-family: 'Courier New', Courier, monospace;
                            }
                             .sans{
                               font - family: Arial, Helvetica, sans - serif;
                              }
                            </style>
                            </head>
                            <body>
                        <h1 class='ser'>WebPort Offline htmlSource</h1>
                         <p class='sans'>A local way to write up some html syntax. This is a example of a local webpage for support information.</p>
                        </body></html>";
                MyWeb.Source = htmlSource;
            }
        }

        async void FooterMainClicked(object sender, EventArgs args)
        {
            //await Navigation.PushAsync(new MainPage());
            await Navigation.PopAsync();
        }

        void FooterAboutClicked(object sender, EventArgs args)
        {
           // await Navigation.PushAsync(new AboutPage());
           //ToDo
        }

        void FooterForwardClicked(object sender, EventArgs args)
        {
            if (MyWeb.CanGoForward)
            {
                MyWeb.GoForward();
            }
        }

        void FooterBackClicked(object sender, EventArgs args)
        {
            if (MyWeb.CanGoBack)
            {
                MyWeb.GoBack();
            }
            else
            {
                MyWeb.Source = App.webURL;
            }
        }

        // WebView wv = this.MyWeb;
        //await Navigation.PopAsync();
        //if (wv.CanGoBack)
        //{
        //    wv.GoBack();
        //}
        //await Navigation.PushAsync(new AboutPage());
    }
}
