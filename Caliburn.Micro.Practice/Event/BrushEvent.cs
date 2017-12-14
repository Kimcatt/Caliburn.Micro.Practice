using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Caliburn.Micro.Practice.Event
{
    public class BrushEvent
    {
        public BrushEvent(SolidColorBrush solidColorBrush)
        {
            Brush = solidColorBrush;
        }

        public SolidColorBrush Brush { get; private set; }
    }
}
