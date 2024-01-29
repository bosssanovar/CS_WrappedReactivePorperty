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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var dat = CreateDataField();
            Data = new ReactivePropertySlim<Data>(dat);
            Data.Subscribe(_ => Dat_TextChanged());

            InitCommand.Subscribe(async _ => await InitAsync());


            InitializeComponent();
        }

        private Data CreateDataField()
        {
            if (_dat is not null)
            {
                _dat.TextChanged -= Dat_TextChanged;
            }
            _dat = new WpfApp1.Data();
            _dat.TextChanged += Dat_TextChanged;

            return _dat;
        }

        protected override void OnClosed(EventArgs e)
        {
            _dat.TextChanged -= Dat_TextChanged;
            base.OnClosed(e);
        }
    }
}