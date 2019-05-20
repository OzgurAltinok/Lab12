using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Model 1");
            IModel model = new IntegerGenerator();
            IView view = new View();
            IController controller = new Controller();
            model.setController(controller);
            controller.setView(view);
            controller.setModel(model);
            controller.getRequestFromModel();
            /*Model 2 */
            Console.WriteLine("Model 2");
            model = new SequenceGenerator();
            model.setController(controller);
            controller.setModel(model);
            controller.getRequestFromModel();
            /*Model 3*/
            Console.WriteLine("Model 3");
            model = new StringGenerator();
            model.setController(controller);
            controller.setModel(model);
            controller.getRequestFromModel();
            Console.ReadLine();
        }
    }
}
