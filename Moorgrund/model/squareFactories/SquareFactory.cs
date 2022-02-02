using System;
using Moorgrund.model.square;
using System.Collections.Generic;

namespace Moorgrund.model.squareFactories {
    class SquareFactory {

        private List<Factory> factories = new List<Factory>();

        public SquareFactory() {
            factories.Add(new TreeFactory());
            factories.Add(new GrassFactory());
            factories.Add(new RockFactory());
        }

        private Factory getFactoryByName(String name) {
            foreach(Factory factory in factories) {
                if (factory.Is(name)) {
                    return factory;
                }
            }
            return null;
        }

        public Square MakeTree() {
            return getFactoryByName("Tree").Make();
        }

        public Square MakeGrass() {
            return getFactoryByName("Grass").Make();
        }

        public Square MakeRock() {
            return getFactoryByName("Rock").Make();
        }

        public Square Make() {
            return factories[new Random().Next(factories.Count)].Make();
        }
    }
}
