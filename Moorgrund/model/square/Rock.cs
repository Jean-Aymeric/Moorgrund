using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.square {
    class Rock : Square {
        private static readonly char[,] RockText = {    { '░', '░', '░', '░' },
                                                        { '░', '░', '░', '░' },
                                                        { '░', '░', '░', '░' } };
        public Rock() : base(new Sprite(RockText), true) {
        }
    }
}
