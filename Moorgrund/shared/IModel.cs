using System;


namespace Moorgrund.shared {
    interface IModel {
        IMobile Paracrobunus { get; }
        String Test();
        IWorld World { get; }
    }
}
