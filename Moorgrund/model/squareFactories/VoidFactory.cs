using Moorgrund.model.square;

namespace Moorgrund.model.squareFactories {
    class VoidFactory : Factory {
        private Void buildedVoid= new Void();
        public VoidFactory() : base("Void")
        {
        }

        public override Square Make()
        {
            return buildedVoid;
        }
    }
}
