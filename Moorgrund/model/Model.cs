using Moorgrund.model.mobile;
using Moorgrund.shared;
using System;

namespace Moorgrund.model {
    class Model : Observable, IModel {
        private static int Width = 118;
        private static int Height = 29;       
        public IWorld World { get; }
        public IMobile Paracrobunus { get; }

        public Model() {
            World = new World(Width, Height);
            Paracrobunus = new Paracrobunus(10,10,this);
        }

        public string Test() {
            return "OK";
        }
    }
}
