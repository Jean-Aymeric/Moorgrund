using Moorgrund.shared;
using System;


namespace Moorgrund.model.square {
    abstract class Square : shared.ISquare {
        public shared.ISprite Sprite { get; set; }
        public bool Traversable { get; set; }

        public Square(shared.ISprite sprite, bool traversable) {
            Sprite = sprite;
            Traversable = traversable;
        }
    }
}
