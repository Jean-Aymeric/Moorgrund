using Moorgrund.shared;
using System;

namespace Moorgrund.view {
    class View : shared.IView {
        public shared.IModel Model { get; set; }
        public shared.IController Controller { get; set; }
        public int WindowHeight { get; set; }
        public int WindowWidth { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public void Display() {
            bool running = true;
            bool show = false;
            PositionX = Model.Paracrobunus.X;
            PositionY = Model.Paracrobunus.Y;
            do {
                do {
                    Console.Clear();
                    printWorld();
                    show = false;
                } while (!Console.KeyAvailable && show);
                
                ConsoleKey Key = Console.ReadKey(true).Key;
                if (Key == ConsoleKey.LeftArrow) {
                    PositionX--;
                    show = true;
                }
                if (Key == ConsoleKey.RightArrow) {
                    PositionX++;
                    show = true;
                }
                if (Key == ConsoleKey.UpArrow) {
                    PositionY--;
                    show = true;
                }
                if (Key == ConsoleKey.DownArrow) {
                    PositionY++;
                    show = true;
                }
                if (Key == ConsoleKey.Escape) {
                    running = false;
                }
            } while (running);

        }

        private void printWorld() {
            for (int y = -WindowHeight / 2; y < (WindowHeight / 2) + (WindowHeight % 2); y++) {
                Console.Write(getOneLineOfWorld(y));
            }
        }


        private string getOneLineOfWorld(int y) {
            string OneLineOfWorld = "";
            for (int ligne = 0; ligne < ISprite.TextImageHeight; ligne++) {
                for (int x = -WindowWidth / 2; x < (WindowWidth / 2) + (WindowWidth % 2); x++) {
                    for (int i = 0; i < ISprite.TextImageWidth; i++) {
                        if(Model.Paracrobunus.X == PositionXToWorldX(x) && Model.Paracrobunus.Y == PositionYToWorldY(y))
                        {
                            OneLineOfWorld += Model.Paracrobunus.Sprite.TextImage[ligne, i];
                        }else
                        {
                            OneLineOfWorld += Model.World.GetSquare(PositionXToWorldX(x), PositionYToWorldY(y)).Sprite.TextImage[ligne, i];
                        }
                    }
                }
                OneLineOfWorld += "\n";
            }
            return OneLineOfWorld;
        }

        private int PositionXToWorldX(int x) {
            return PositionX + x;
        }

        private int PositionYToWorldY(int y) {
            return PositionY + y;
        }
    }
}