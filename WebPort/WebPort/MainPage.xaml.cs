using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebPort
{
    public partial class MainPage : ContentPage
    {
        string webURL = "";
        string localURL = "";

        public MainPage()
        {
            InitializeComponent();
            //var browser = new WebView
            //{
            //    //Source = "http://winecodaveuncilofontario.ca/"
            //    Source = "http://winecouncilofontario.ca/"
            //};
            //// The root page of your application
            //var content = new ContentPage
            //{
            //    Content = browser
            //};
            //Navigation.PushAsync(content);
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);

            if (App.isOnline)
            {
                webURL = App.webURL;
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
                        <h1 class='ser'>htmlSource</h1>
                         <p class='sans'>A local way to write up some html syntax.</p>
                        </body></html>";
                MyWeb.Source = htmlSource;
            }
        }

        void webOnNavigating(object sender, WebNavigatingEventArgs e)
        {
            LoadingLabel.IsVisible = true;
        }

        void webOnEndNavigating(object sender, WebNavigatedEventArgs e)
        {
            LoadingLabel.IsVisible = false;
            webURL = MyWeb.Source.ToString();
            Debug.WriteLine(webURL);
        }

        void FooterMainClicked(object sender, EventArgs args)
        {
            //  await Navigation.PushAsync(new MainPage());         
                MyWeb.Source = App.webURL;
        }

        async void FooterAboutClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AboutPage());
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
    }
}
