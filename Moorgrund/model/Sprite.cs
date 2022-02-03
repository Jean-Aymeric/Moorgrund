using Moorgrund.shared;
using System;

namespace Moorgrund.model {
    class Sprite : shared.ISprite {


        public char[,] TextImage { get; set; }

        public Sprite(char[,] textImage) {
            TextImage = new char[ISprite.TextImageHeight, ISprite.TextImageWidth];
            TextImage = textImage;
        }

    }
}
