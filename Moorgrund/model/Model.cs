using Moorgrund.model.mobile;
using Moorgrund.shared;
using System;

namespace Moorgrund.model {
    class Model : shared.IModel {
        private static int Width = 118;
        private static int Height = 29;       
        public IWorld World { get; }
        public IMobile Paracrobunus { get; }

        public Model() {
            World = new World(Width, Height);
            Paracrobunus = new Paracrobunus(10,10,World);
        }

        public string Test() {
            return "OK";
        }
    }
}
