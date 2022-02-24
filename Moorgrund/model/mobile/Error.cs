using Moorgrund.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.mobile
{
    class Error : Mobile
    {
        private static readonly char[,] PlayerText = {  { '-', '-', '-', '-' },
                                                        { '+', '-', '-', ' ' },
                                                        { '-', '-', '-', '-' } };
        public Error() : base(new Sprite(PlayerText), 1, 1, null) { }

        public override bool isSquareFree(int x, int y) {
            return Model.World.GetSquare(x, y).Traversable;
        }
    }
}
