using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab12
{
    interface IModel
    {
         void getRequest();
         void notify();
         void setController(IController i);
    }
}
