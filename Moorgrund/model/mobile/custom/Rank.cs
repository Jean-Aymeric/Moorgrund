using Moorgrund.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.mobile.custom {
    class Rank : Custom {
        private int Level {get;}

        public Rank(IMobile mobile, int level) : base(mobile) {
            Level = level;
        }

        protected override char getSpriteXYDecorated(int x, int y) {
            if (x == 0 && y == 0) {
                return (char)(Level + '0');
            }

            return Mobile.getSpriteXY(x, y);
        }
    }
}
