using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.shared {
    interface IWorld {
        public int Width { get; set; }
        public int Height { get; set; }
        public ISquare GetSquare(int x, int y);
    }
}
