using Moorgrund.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.mobile.custom {
    class Warrior : Custom {
        public Warrior(IMobile mobile) : base(mobile) { }

        protected override char getSpriteXYDecorated(int x, int y) {
            if (x == 3 && y == 0) {
                return '|';
            }
            if (x == 3 && y == 1) {
                return '+';
            }
            return Mobile.getSpriteXY(x, y);
        }
    }
}
