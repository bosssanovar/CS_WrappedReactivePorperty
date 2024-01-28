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


        public ReadOnlyReactivePropertySlim<string> Display { get; }

        public AsyncReactiveCommand InitCommand { get; } = new AsyncReactiveCommand();

        public async Task InitAsync()
        {
            await Task.Delay(1000);

            Data.Value = new Data();
        }
    }
}
