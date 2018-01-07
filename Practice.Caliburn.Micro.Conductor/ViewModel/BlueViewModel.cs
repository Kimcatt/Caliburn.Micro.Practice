using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using Caliburn.Micro;
using System.Windows.Media;

namespace Practice.Caliburn.Micro.Conductor.ViewModel
{
    [Export(typeof(GreenViewModel))]
    public class BlueViewModel : Screen
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


        public BlueViewModel()
        {
            fontColor = new SolidColorBrush(Colors.Blue);
        }
        

    }
}
