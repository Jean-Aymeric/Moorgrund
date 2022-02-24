using Moorgrund.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.mobile.custom {
    class Flying : Custom {
        public Flying(IMobile mobile) : base(mobile) { }

        protected override char getSpriteXYDecorated(int x, int y) {
            return Mobile.getSpriteXY(x, y);
        }

        public override bool isSquareFree(int x, int y) {
            return true;
        }
    }
}
