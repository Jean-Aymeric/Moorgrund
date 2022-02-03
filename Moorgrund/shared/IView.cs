using System;

namespace Moorgrund.shared {
    interface IView {
        public shared.IModel Model { get; set; }
        public shared.IController Controller { get; set; }
        public int WindowHeight { get; set; }
        public int WindowWidth { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public void Display();
    }
}
