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
        public AboutPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);

            MyWeb.Source = App.webURL + "about/";
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
            await Navigation.PopAsync();
            //if (wv.CanGoBack)
            //{
            //    wv.GoBack();
            //}
            //await Navigation.PushAsync(new AboutPage());
        }
    }
}
