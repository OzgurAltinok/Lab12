using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab12
{
    interface IController
    {
        void updateView(string input);
        void getRequestFromModel();
        void setModel(IModel m);
        void setView(IView v);
    }
}
