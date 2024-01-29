using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Data
    {
        public const string InitText1 = "Text1";
        const string InitText2 = "Text2";
        private string text1 = string.Empty;

        public string Text1
        {
            get => text1;
            set {
                text1 = value;
                TextChanged?.Invoke();
            }
        }
        public string Text2 { get; set; } = string.Empty;

        public event Action? TextChanged;

        public Data()
        {
            Init();
        }

        public void Init()
        {
            Text1 = InitText1;
            Text2 = InitText2;
        }
    }
}
