using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XForms.Examples.Pages
{
    public partial class EffectsPage : ContentPage
    {
        public EffectsPage()
        {
            InitializeComponent();

            entry.Effects.Add(Effect.Resolve("MyCompany.BackgroundColorEffect"));
        }
    }
}
