using Moorgrund.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.mobile.custom {
    class Shield : Custom {
        public Shield(IMobile mobile) : base(mobile) { }

        protected override char getSpriteXYDecorated(int x, int y) {
            if (x == 0 && y == 1) {
                return '[';
            }

            return Mobile.getSpriteXY(x, y);
        }
    }
}
