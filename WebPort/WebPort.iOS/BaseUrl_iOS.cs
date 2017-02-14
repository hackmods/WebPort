using Foundation;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using WebPort.iOS;

[assembly: Dependency(typeof(BaseUrl_iOS))]
namespace WebPort.iOS
{
    public class BaseUrl_iOS : IBaseUrl
    {
        public string Get()
        {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}

