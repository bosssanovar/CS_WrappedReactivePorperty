using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public partial class MainWindow
    {
        public ReactivePropertySlim<string> Text { get; }
        public ReadOnlyReactivePropertySlim<string> Display { get; }

        public string InnerText { get; set; } = "Init";

        public ReactiveCommand InitCommand { get; } = new ReactiveCommand();

        public void Init()
        {
            InnerText = "Init";
        }
    }
}
