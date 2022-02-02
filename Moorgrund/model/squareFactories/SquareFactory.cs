using System;
using Moorgrund.model.square;
using System.Collections.Generic;

namespace Moorgrund.model.squareFactories {
    class SquareFactory {
        private static SquareFactory Instance;

        private List<Factory> factories = new List<Factory>();

        private SquareFactory() {
            factories.Add(new TreeFactory());
            factories.Add(new GrassFactory());
            factories.Add(new RockFactory());
        }

        public static SquareFactory GetInstance() {
            if (Instance == null) {
                Instance = new SquareFactory();
            }
            return Instance;
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
