using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using Practice.Caliburn.Micro.Event;
using System.Windows.Media;
using Caliburn.Micro;

namespace Practice.Caliburn.Micro.ViewModel
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
