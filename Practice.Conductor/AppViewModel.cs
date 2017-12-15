using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace Practice.Conductor
{
    [Export(typeof(AppViewModel))]
    public class AppViewModel : Conductor<object> 
    {
        public void ShowRedScreen()
        {
            ActivateItem(new ViewModel.RedViewModel());
        }
        public void ShowBlueScreen()
        {
            ActivateItem(new ViewModel.BlueViewModel());
        }

        public void ShowGreenScreen()
        {
            ActivateItem(new ViewModel.GreenViewModel());
        }
    }
}
