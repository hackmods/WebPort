using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPort.UWP;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl))]
namespace WebPort.UWP
{
    public class BaseUrl : IBaseUrl
    {
        public string Get()
        {
            return "ms-appx-web:///";
        }
    }
}
