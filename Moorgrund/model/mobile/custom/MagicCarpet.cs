using Moorgrund.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.mobile.custom {
    class MagicCarpet : Custom {
        public MagicCarpet(IMobile mobile) : base(mobile) { }

        protected override char getSpriteXYDecorated(int x, int y) {
            if (y == 2) {
                return '~';
            }

            return Mobile.getSpriteXY(x, y);
        }
    }
}
