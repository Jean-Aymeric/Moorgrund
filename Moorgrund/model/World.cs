using System;
using System.Collections.Generic;


namespace Moorgrund.model {
    class World : shared.IWorld {
        public int Width { get; set; }
        public int Height { get; set; }
        private square.Square[,] squares;

        public World(int width, int height) {
            Width = width;
            Height = height;
            squares = new square.Square[Height, Width];
            fillWorld();
        }

        private void fillWorld() {
            squareFactories.SquareFactory factory = new squareFactories.SquareFactory();
            for (int y = 0; y < Height; y++) {
                for (int x = 0; x  < Width; x++) {
                    if ((x == 0) || (x == Width-1) || (y == 0) || (y == Height - 1)) {
                        squares[y, x] = factory.MakeTree();
                    } else {
                        squares[y, x] = factory.Make();
                    }
                }
            }
        }

        public shared.ISquare GetSquare(int x, int y) {
            if (x >= 0 && x < Width && y >= 0 && y < Height) {
                return squares[y, x];
            }
            return null;
        }
    }
}
