using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XForms.Examples.MVVM.Views;
using XForms.Examples.Pages;

namespace XForms.Examples.Navigation
{
    public partial class Main : ContentPage
    {
        public Main()
        {
            InitializeComponent();
            btnTabbed.Clicked += BtnTabbed_Clicked;
            btnStyle.Clicked += BtnStyle_Clicked;
            btnBinding.Clicked += BtnBinding_Clicked;
            btnEffects.Clicked += BtnEffects_Clicked;
            btnOnPlatform.Clicked += BtnOnPlatform_Clicked;
            btnPhoneWord.Clicked += BtnPhoneWord_Clicked;
            btnMVVM.Clicked += BtnMVVM_Clicked;
        }

        private void BtnMVVM_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AlertePage());
        }

        private void BtnPhoneWord_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Phoneword());
        }

        private void BtnOnPlatform_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OnPlatformPage());
        }

        private void BtnEffects_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EffectsPage());
        }

        private void BtnBinding_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BindingPage());
        }

        private void BtnStyle_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StylePage());
        }

        private void BtnTabbed_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Tabbed());
        }        
    }
}
