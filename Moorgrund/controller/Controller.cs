using Moorgrund.shared;
using System;

namespace Moorgrund.controller {
    class Controller : IController {
        private IView view;
        public IView View {
            get => view;
            set {
                view = value;
                if ((model != null) && (view != null)) {
                    view.Model = Model;
                }
                view.Controller = this;
            }
        }

        private IModel model;
        public IModel Model {
            get => model;
            set {
                model = value;
                if ((model != null) && (View != null) && (View.Model != model)) {
                    view.Model = Model;
                }
            }
        }

        public void ManageOrder(Order order) {
            switch (order) {
                case Order.Left:
                    Model.Paracrobunus.MoveLeft();
                    break;
                case Order.Right:
                    Model.Paracrobunus.MoveRight();
                    break;
                case Order.Up:
                    Model.Paracrobunus.MoveUp();
                    break;
                case Order.Down:
                    Model.Paracrobunus.MoveDown();
                    break;
                default:
                    break;
            }
        }
    }
}
