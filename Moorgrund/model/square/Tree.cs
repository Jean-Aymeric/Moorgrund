using System;


namespace Moorgrund.model.square {
    class Tree : Square {
        private static readonly char[, ] TreeText = {   { ' ', '/', '\\', ' ' },
                                                        { '/', '_', '_', '\\' },
                                                        { ' ', '▒', '▒', ' ' } };

        public Tree() : base(new Sprite(TreeText), false) {
        }
    }
}
