using Moorgrund.model.square;

namespace Moorgrund.model.squareFactories {
    class RockFactory : Factory {
        private Rock buildedRock = new Rock();
        public RockFactory() : base("Rock") {
        }

        public override Square Make()
        {
            return buildedRock;
        }
    }
}
