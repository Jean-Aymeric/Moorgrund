using System;

namespace Moorgrund.shared {
    interface IView {
        public shared.IModel Model { get; set; }
        public shared.IController Controller { get; set; }

        public void Display();
    }
}
