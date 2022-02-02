using System;

namespace Moorgrund.controller {
    class Controller : shared.IController {
        private shared.IView view;
        public shared.IView View {
            get => view;
            set {
                view = value;
                if ((model != null) && (view != null)) {
                    view.Model = Model;
                }
            }
        }

        private shared.IModel model;
        public shared.IModel Model {
            get => model;
            set {
                model = value;
                if ((model != null) && (View != null) && (View.Model != model)) {
                    view.Model = Model;
                }
            }
        }
    }
}
