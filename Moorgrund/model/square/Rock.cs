using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.square {
    class Rock : Square {
        public Rock() : base(new Sprite('o'), true) {
        }
    }
}
