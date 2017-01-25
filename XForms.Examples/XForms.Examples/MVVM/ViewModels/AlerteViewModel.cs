using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XForms.Examples.MVVM.Helper;
using XForms.Examples.MVVM.Models;

namespace XForms.Examples.MVVM.ViewModels
{
    public class AlerteViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }        

        private ObservableCollection<Alerte> _alertes;
        public ObservableCollection<Alerte> Alertes
        {
            get { return _alertes; }
            set { _alertes = value; OnPropertyChanged(); }
        }

        public AlerteViewModel()
        {            
            Initialize();
        }


        protected async Task Initialize()
        {
            Alertes = AlerteHelper.GetAlertes(); ;
        }        
    }
}
