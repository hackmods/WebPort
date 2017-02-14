using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebPort
{
    public class FontAwesomeIcon : Label
    {
        //Must match the exact "Name" of the font which you can get by double clicking the TTF in Windows
        public const string Typeface = "FontAwesome";

        //Constructor for XAML use
        //<local:FontAwesomeIcon Text="{x:Static local:FontAwesomeIcon.Icon.Gear}"></local:FontAwesomeIcon>
        public FontAwesomeIcon()
        {
            FontFamily = Typeface;
        }

        public FontAwesomeIcon(string fontAwesomeIcon = null)
        {
            FontFamily = Typeface;    //iOS is happy with this, Android needs a renderer to add ".ttf"
            Text = fontAwesomeIcon;
        }

        public static string Plus = "\uf067";
        public static string Globe = "";
        /// <summary>
        /// Get more icons from http://fortawesome.github.io/Font-Awesome/cheatsheet/
        /// Tip: Just copy and past the icon picture here to get the icon
        /// </summary>
        public static class Icon
        {
            public static string Gear = "";
            public static string Globe = "";
            public static string Search = "\uf002";
            public static string Plus = "\uf067";
        }
    }
}
