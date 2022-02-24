using Moorgrund.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.mobile.custom {
    class Woman : Custom {
        public Woman(IMobile mobile) : base(mobile) { }

        protected override char getSpriteXYDecorated(int x, int y) {
           if (x == 1 && y == 0) {
                return 'ô';
           }
           return Mobile.getSpriteXY(x, y);
        }
    }
}
