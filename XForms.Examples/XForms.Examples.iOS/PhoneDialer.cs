using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using UIKit;
using XForms.Examples.iOS;
using XForms.Examples.Core;
using Foundation;

[assembly: Dependency(typeof(PhoneDialer))]
namespace XForms.Examples.iOS
{
    public class PhoneDialer : IDialer
    {
        public bool Dial(string number)
        {
            return UIApplication.SharedApplication.OpenUrl(
                new NSUrl("tel:" + number));
        }
    }
}
