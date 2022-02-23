using System;
using System.Collections.Generic;

namespace Moorgrund.shared {
    interface IModel {
        IMobile Paracrobunus { get; }
        List<ICreature> Creatures { get; }
        String Test();
        IWorld World { get; }
        void AddObserver(IObserver observer);
        void RemoveOberver(IObserver observer);
        IMobile GetMobileByXY(int x, int y);
        bool Changed { get; set; }
    }
}
