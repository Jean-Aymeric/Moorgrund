using System;

namespace Moorgrund.shared {
    interface IController {
        public shared.IView View { get; set; }
        public shared.IModel Model { get; set; }
    }
}
