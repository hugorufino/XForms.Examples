using Windows.ApplicationModel.Calls;
using Xamarin.Forms;
using XForms.Examples.Core;
using XForms.Examples.WinPhone;

[assembly: Dependency(typeof(PhoneDialer))]
namespace XForms.Examples.WinPhone
{
    public class PhoneDialer : IDialer
    {
        public bool Dial(string number)
        {
            PhoneCallManager.ShowPhoneCallUI(number, string.Empty);
            return true;
        }
    }
}