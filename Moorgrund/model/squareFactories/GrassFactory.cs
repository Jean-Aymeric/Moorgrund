using Moorgrund.model.square;

namespace Moorgrund.model.squareFactories {
    class GrassFactory : Factory {
        private Grass buildedGrass = new Grass();

        public GrassFactory() : base("Grass") {
        }

        public override Square Make()
        {
            return buildedGrass;
        }
    }
}
