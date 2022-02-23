using System;

namespace Moorgrund.shared {
    interface IController {
        IView View { get; set; }
        IModel Model { get; set; }
        void ManageOrder(Order order);
        void GameLoop();
    }
}
