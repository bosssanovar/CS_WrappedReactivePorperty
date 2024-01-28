using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System.Reactive.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // TODO K.I : 内部プロパティの変更も通知されるの！？
            var dat = new WpfApp1.Data();
            Data = new ReactivePropertySlim<Data>(dat);

            // TODO K.I : どうやればこれが更新される？
            Display = Data.Select(x => x.Text1 + "Disp.").ToReadOnlyReactivePropertySlim<string>();

            InitCommand.Subscribe(async _ => await InitAsync());


            InitializeComponent();
        }
    }
}