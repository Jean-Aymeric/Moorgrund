using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.shared {
    interface ISquare {
        public ISprite Sprite { get; set; }
        public bool Traversable { get; set; }
    }
}
