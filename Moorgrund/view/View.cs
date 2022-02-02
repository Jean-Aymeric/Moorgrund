using System;

namespace Moorgrund.view {
    class View : shared.IView {
        public shared.IModel Model { get; set; }
        public shared.IController Controller { get; set; }

        public void Display() {
            for (int y = 0; y < Model.World.Height; y ++) {
                for (int x = 0; x < Model.World.Width; x++) {
                    Console.Write(Model.World.GetSquare(x, y).Sprite.TextImage);
                }
                Console.WriteLine(" ");
            }
        }
    }
}