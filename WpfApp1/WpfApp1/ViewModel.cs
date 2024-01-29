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
    public partial class MainWindow : INotifyPropertyChanged
    {
        public Data _dat;

        public ReactivePropertySlim<Data> Data { get; set; }

        public string Display
        {
            get { return Data.Value.Text1 + ", " + Data.Value.Text2; }
        }

        public AsyncReactiveCommand InitCommand { get; } = new AsyncReactiveCommand();

        public event PropertyChangedEventHandler? PropertyChanged;

        public async Task InitAsync()
        {
            await Task.Delay(1000); // 重い処理のダミー。AsyncReactiveCommandなので、処理が終わるまでボタンが押せない。多重押下防止。

#if true
            // こちらだと、Data関連全ての変更通知が飛ぶ
            CreateDataField();
            Data.Value = _dat;
#else
            // こちらだと、Data.Value.Text1単独の通知が飛ぶわけではないので、強制通知が必要
            Data.Value.Text1 = WpfApp1.Data.InitText1;
            Data.ForceNotify();
#endif
        }

        private void Dat_TextChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Display)));
        }
    }
}
