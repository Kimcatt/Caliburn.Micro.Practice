using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using Caliburn.Micro.Practice.Event;
using System.Windows.Media;

namespace Caliburn.Micro.Practice.ViewModel
{
    [Export(typeof(BrushViewModel))]
    public class BrushViewModel
    {
        private readonly IEventAggregator eventAggregator;

        [ImportingConstructor]
        public BrushViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
        }

        public void Red()
        {
            eventAggregator.PublishOnCurrentThread(new BrushEvent(new SolidColorBrush(Colors.Red)));
        }

        public void Green()
        {
            eventAggregator.PublishOnCurrentThread(new BrushEvent(new SolidColorBrush(Colors.Green)));
        }

        public void Blue()
        {
            eventAggregator.PublishOnCurrentThread(new BrushEvent(new SolidColorBrush(Colors.Blue)));
        }
    }
}
