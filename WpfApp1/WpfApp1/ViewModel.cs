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
        public ReactivePropertySlim<Data> Data { get; set; }


        public ReactiveProperty<string> Text { get; }
        public ReadOnlyReactivePropertySlim<string> Display { get; }

        public ReactiveCommand InitCommand { get; } = new ReactiveCommand();

        public void Init()
        {
            Data.Value = new Data();
        }
    }
}
