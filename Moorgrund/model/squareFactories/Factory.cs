using System;

using Moorgrund.model.square;

namespace Moorgrund.model.squareFactories {
    abstract class Factory {
        protected String Name { get; private set; }

        public Factory(String name) {
            Name = name;
        }
        public abstract Square Make();

        public bool Is(String name) {
            return Name.Equals(name);
        }
    }
}
