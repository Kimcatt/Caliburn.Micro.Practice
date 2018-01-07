using System;
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Media;
using Practice.Caliburn.Micro.Event;
using Caliburn.Micro;
using Practice.Caliburn.Micro.ViewModel;

namespace Practice.Caliburn.Micro
{
    [Export(typeof(IShell))]
    public class ShellViewModel : global::Caliburn.Micro.PropertyChangedBase, IShell, IHandle<Event.BrushEvent>
    {
        public ViewModel.BrushViewModel BrushModel { get; private set; }

        string name = "你好，请开始Caliburn.Micro之旅！";

        private System.Timers.Timer clockTimer;

        private DateTime now = DateTime.Now;

        public DateTime Now
        {
            get
            {
                return now;
            }
            set
            {
                now = value;
                NotifyOfPropertyChange(() => Now);
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyOfPropertyChange(() => Name);
                //NotifyOfPropertyChange(() => CanWelcome);
            }
        }

        private SolidColorBrush color = new SolidColorBrush(Colors.LightSkyBlue);
        public SolidColorBrush Color
        {
            get { return color; }
            set
            {
                color = value;
                NotifyOfPropertyChange(() => Color);
            }
        }

        private readonly IWindowManager _windowManager;

        [ImportingConstructor]
        public ShellViewModel(ViewModel.BrushViewModel brushModel, IEventAggregator eventAggregator, IWindowManager windowManager)
        {
            BrushModel = brushModel;
            
            clockTimer = new System.Timers.Timer();
            clockTimer.Interval = TimeSpan.FromSeconds(1).TotalMilliseconds;
            clockTimer.Elapsed += (sender, e) =>
            {
                Now = DateTime.Now;
            };
            clockTimer.Start();
            _windowManager = windowManager;
            eventAggregator.Subscribe(this);
        }


        //public bool CanWelcome
        //{
        //    get { return !string.IsNullOrWhiteSpace(Name); }
        //}

        public void Welcome()
        {
            MessageBox.Show(string.Format("提示： {0}", Name)); //Don't do this in real life :)
        }

        public void OpenWindow()
        {
            _windowManager.ShowWindow(new AboutViewModel(_windowManager));
        }

        public void Handle(BrushEvent message)
        {
            Color = message.Brush;
        }
    }
}
