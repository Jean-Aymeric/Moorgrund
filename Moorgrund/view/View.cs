using Moorgrund.shared;
using System;
using System.Threading;

namespace Moorgrund.view {
    class View : IView, IObserver {
        private IModel _model;
        public IModel Model { get => _model; set { if (value != null) { value.AddObserver(this); } _model = value; } }
        public IController Controller { get; set; }
        public int WindowHeight { get; set; }
        public int WindowWidth { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        private bool Show { get; set; }

        public void Display() {
            bool running = true;
            Show = true;
            do {
                if (Show) {
                    PositionX = Model.Paracrobunus.X;
                    PositionY = Model.Paracrobunus.Y;
                    do {
                        Console.Clear();
                        printWorld();
                        Show = false;
                    } while (!Console.KeyAvailable && Show);
                }

                ConsoleKey Key = Console.ReadKey(true).Key;
                if (Key == ConsoleKey.LeftArrow) {
                    Controller.ManageOrder(Order.Left);
                }
                if (Key == ConsoleKey.RightArrow) {
                    Controller.ManageOrder(Order.Right);
                }
                if (Key == ConsoleKey.UpArrow) {
                    Controller.ManageOrder(Order.Up);
                }
                if (Key == ConsoleKey.DownArrow) {
                    Controller.ManageOrder(Order.Down);
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

        public void Notify() {
            Show = true;
         }
    }
}