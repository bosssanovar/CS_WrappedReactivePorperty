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
            Data = new ReactivePropertySlim<Data>(new WpfApp1.Data());

            Text = Data.Select(x => x.Text1).ToReactiveProperty<string>();
            Text.Subscribe(value =>
            {
                Data.Value.Text1 = value;
                Data.ForceNotify();//これはただの表示更新用。これが無くても、内部値はきちんと更新されている
            });

            Display = Text.Select(x => x + "Disp.").ToReadOnlyReactivePropertySlim<string>();

            InitCommand.Subscribe(_ => Init());


            InitializeComponent();
        }
    }
}