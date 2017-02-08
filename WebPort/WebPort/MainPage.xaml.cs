using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebPort
{
    public partial class MainPage : ContentPage
    {
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
            MyWeb.Source = App.webURL;
        }

        void webOnNavigating(object sender, WebNavigatingEventArgs e)
        {
            LoadingLabel.IsVisible = true;
        }

        void webOnEndNavigating(object sender, WebNavigatedEventArgs e)
        {
            LoadingLabel.IsVisible = false;
        }

        async void FooterMainClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MainPage());
        }

        async void FooterAboutClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AboutPage());
        }
        async void BackClicked(object sender, EventArgs args)
        {
            WebView wv = this.MyWeb;
            wv.Source = "http://google.ca";
  //          await Navigation.PopAsync();
            //if (wv.CanGoBack)
            //{
            //    wv.GoBack();
            //}
            //await Navigation.PushAsync(new AboutPage());
        }
    }
}
