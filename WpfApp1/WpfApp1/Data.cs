using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Data
    {
        const string InitText1 = "Text1";
        const string InitText2 = "Text2";

        public string Text1 { get; set; } = string.Empty;
        public string Text2 { get; set; } = string.Empty;

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
