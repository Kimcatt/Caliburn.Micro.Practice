using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace Practice.Caliburn.Micro.ViewModel
{
    [Export(typeof(AboutViewModel))]
    public class AboutViewModel : PropertyChangedBase
    {
        private readonly IWindowManager _windowManager;

        [ImportingConstructor]
        public AboutViewModel(IWindowManager windowManager)
        {
            _windowManager = windowManager;
        }


    }
}
