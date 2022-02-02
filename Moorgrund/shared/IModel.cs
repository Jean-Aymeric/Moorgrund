using System;


namespace Moorgrund.shared {
    interface IModel {
        String Test();
        IWorld World { get; }
    }
}
