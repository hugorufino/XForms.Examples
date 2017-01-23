using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XForms.Examples.Droid;

[assembly:ResolutionGroupName ("MyCompany")]
[assembly:ExportEffect (typeof(BackgroundColorEffect), "BackgroundColorEffect")]
namespace XForms.Examples.Droid
{
    public class BackgroundColorEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                Control.SetBackgroundColor(Android.Graphics.Color.LightGreen);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }

        protected override void OnDetached()
        {

        }
    }
}

