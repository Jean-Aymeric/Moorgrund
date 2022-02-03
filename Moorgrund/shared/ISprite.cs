using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.shared {
    interface ISprite {
        public static int TextImageWidth = 4;
        public static int TextImageHeight = 3;
        public char[,] TextImage { get; set; }
    }
}
