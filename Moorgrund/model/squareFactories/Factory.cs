using System;

using Moorgrund.model.square;

namespace Moorgrund.model.squareFactories {
    abstract class Factory {
        protected String Name { get; private set; }
        private Square BuildedSquare { get; set;  }

        public Factory(String name, Square buildedSquare) {
            Name = name;
            BuildedSquare = buildedSquare;
        }
        public Square Make() {
            return BuildedSquare;
        }

        public bool Is(String name) {
            return Name.Equals(name);
        }
    }
}
