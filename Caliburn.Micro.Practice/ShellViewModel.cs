using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Caliburn.Micro.Practice
{
    [Export(typeof(IShell))]
    public class ShellViewModel : Caliburn.Micro.PropertyChangedBase, IShell
    {
        string name = "你好，请开始Caliburn.Micro之旅！";

        private System.Timers.Timer clockTimer;

        DateTime now = DateTime.Now;

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


        public ShellViewModel()
        {
            clockTimer = new System.Timers.Timer();
            clockTimer.Interval = TimeSpan.FromSeconds(1).TotalMilliseconds;
            clockTimer.Elapsed += (sender, e) =>
            {
                Now = DateTime.Now;
            };
            clockTimer.Start();
        }


        //public bool CanWelcome
        //{
        //    get { return !string.IsNullOrWhiteSpace(Name); }
        //}

        public void Welcome()
        {
            MessageBox.Show(string.Format("提示： {0}", Name)); //Don't do this in real life :)
        }
    }
}
