using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.square {
    class Void : Square {
        private static readonly char[,] VoidText = {    { '█', '█', '█', '█' },
                                                        { '█', '█', '█', '█' },
                                                        { '█', '█', '█', '█' } };
        public Void() : base(new Sprite(VoidText), true) {
        }
    }
}
