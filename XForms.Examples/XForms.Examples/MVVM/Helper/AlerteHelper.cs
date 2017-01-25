using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XForms.Examples.MVVM.Models;

namespace XForms.Examples.MVVM.Helper
{
    public static class AlerteHelper
    {
        public static ObservableCollection<Alerte> GetAlertes()
        {
            ObservableCollection<Alerte> alertes = new ObservableCollection<Alerte>();

            alertes.Add(new Models.Alerte() { Description = "Alerte 1", Date = new DateTime(2017, 1, 2) });
            alertes.Add(new Models.Alerte() { Description = "Alerte 2", Date = new DateTime(2017, 1, 3) });
            alertes.Add(new Models.Alerte() { Description = "Alerte 3", Date = new DateTime(2017, 1, 4) });
            alertes.Add(new Models.Alerte() { Description = "Alerte 4", Date = new DateTime(2017, 1, 5) });
            alertes.Add(new Models.Alerte() { Description = "Alerte 5", Date = new DateTime(2017, 1, 6) });

            return alertes;
        }

        public static void Delete(Alerte alerte)
        {

        }
    }
}
