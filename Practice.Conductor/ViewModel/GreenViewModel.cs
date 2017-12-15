using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using Caliburn.Micro;
using System.Windows.Media;

namespace Practice.Conductor.ViewModel
{
    [Export(typeof(GreenViewModel))]
    public class GreenViewModel : Screen
    {
        private SolidColorBrush fontColor;

        public SolidColorBrush FontColor
        {
            get { return fontColor; }
            private set
            {
                fontColor = value;
                NotifyOfPropertyChange(() => FontColor);
            }

        }


        public GreenViewModel()
        {
            fontColor = new SolidColorBrush(Colors.Green);
        }
        

    }
}
