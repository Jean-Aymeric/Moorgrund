using System;


namespace Moorgrund.shared {
    interface IModel {
        IMobile Paracrobunus { get; }
        String Test();
        IWorld World { get; }
        void AddObserver(IObserver observer);
        void RemoveOberver(IObserver observer);
        bool Changed { get; set; }
    }
}
