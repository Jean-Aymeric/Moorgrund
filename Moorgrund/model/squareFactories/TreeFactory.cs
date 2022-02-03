using Moorgrund.model.square;
using System;


namespace Moorgrund.model.squareFactories {
    class TreeFactory : Factory {
        private Tree[] BuildedTrees = { new Oak(), new Fir(), new Chestnut()};
        
        public TreeFactory() : base("Tree") {
        }

        public override Square Make()
        {
            return BuildedTrees[new Random().Next(BuildedTrees.Length)];
        }
    }
}
