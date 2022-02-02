using System;

namespace Moorgrund.view {
    class View : shared.IView {
        public shared.IModel Model { get; set; }
        public shared.IController Controller { get; set; }

        public void display() {
            Console.WriteLine(Model.test());
        }
    }
}
