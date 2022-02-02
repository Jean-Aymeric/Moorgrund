using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.square {
    class Grass : Square {
        public Grass() : base(new Sprite('.'), true) {
        }
    }
}
