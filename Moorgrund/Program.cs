using System;

namespace Moorgrund {
    class Program {
        static void Main(string[] args) {
            shared.IController controller = new controller.Controller();
            shared.IView view = new view.View();
            shared.IModel model = new model.Model();

            controller.Model = model;
            controller.View = view;
            view.PositionX = 3;
            view.PositionY = 2;
            view.WindowWidth = 29;
            view.WindowHeight = 10;
            view.Display();
        }
    }
}