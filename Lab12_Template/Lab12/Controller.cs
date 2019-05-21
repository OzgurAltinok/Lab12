using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab12
{
    class Controller : IController
    {
        IModel myModel;
        IView myView = new View();

        internal IModel MyModel { get => myModel; set => myModel = value; }
        internal IView MyView { get => myView; set => myView = value; }

        public void getRequestFromModel()
        {
            MyModel.getRequest();
        }

        public void setModel(IModel m)
        {
            MyModel = m;
        }

        public void setView(IView v)
        {
            MyView = v;
        }

        public void updateView(string input)
        {
            MyView.update(input);
        }
    }
}
