using System;


namespace Moorgrund.model.square {
    class Tree : Square {
       
        public Tree(char[,] treetext) : base(new Sprite(treetext), false) {
        }
    }
}
