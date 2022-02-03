using System;
using System.Collections.Generic;
using Moorgrund.model.squareFactories;
using Moorgrund.model.square;


namespace Moorgrund.model {
    class World : shared.IWorld {
        public int Width { get; set; }
        public int Height { get; set; }
        private readonly Square[,] squares;

        public World(int width, int height) {
            Width = width;
            Height = height;
            squares = new Square[Height, Width];
            fillWorld();
        }

        private void fillWorld() {
            for (int y = 0; y < Height; y++) {
                for (int x = 0; x  < Width; x++) {
                    if ((x == 0) || (x == Width-1) || (y == 0) || (y == Height - 1)) {
                        squares[y, x] = SquareFactory.GetInstance().MakeTree();
                    } else {
                        squares[y, x] = SquareFactory.GetInstance().Make();
                    }
                }
            }
        }

        public shared.ISquare GetSquare(int x, int y) {
            if (x >= 0 && x < Width && y >= 0 && y < Height) {
                return squares[y, x];
            }
            return SquareFactory.GetInstance().MakeRock(); ;
        }
    }
}
