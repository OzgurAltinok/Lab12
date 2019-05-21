using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab12
{
    class View : IView
    {
        string myStr;

        public string MyStr { get => myStr; set => myStr = value; }

        public void update(string str)
        {
            MyStr = str;
        }
    }
}
