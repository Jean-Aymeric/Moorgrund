using Moorgrund.model.mobile;
using Moorgrund.model.mobile.creature;
using Moorgrund.model.mobile.custom;
using Moorgrund.shared;
using System;
using System.Collections.Generic;

namespace Moorgrund.model {
    class Model : Observable, IModel {
        private static int Width = 118;
        private static int Height = 29;       
        public IWorld World { get; }
        public IMobile Paracrobunus { get; }
        public List<IMobile> Creatures { get; }

        public Model() {
            World = new World(Width, Height);
            Paracrobunus = new Flying(new MagicCarpet(new Shield(new Warrior(new Woman(new Paracrobunus(10,10,this))))));
            Creatures = new List<IMobile>();
            Creatures.Add(new Dragon(12, 12, this));
            Creatures.Add(new Woman(new Troll(14, 14, this)));
        }

        public string Test() {
            return "OK";
        }

        public IMobile GetMobileByXY(int x, int y)
        {
            if (Paracrobunus.X == x && Paracrobunus.Y == y)
            {
                return Paracrobunus;
            }
            foreach (IMobile creature in Creatures)
            {
                if (creature.X == x && creature.Y == y)
                {
                    return creature;
                }
            }
            return null;
        }
    }
}
