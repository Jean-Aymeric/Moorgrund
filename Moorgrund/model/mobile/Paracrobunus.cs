using Moorgrund.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.mobile
{
    class Paracrobunus : Mobile
    {
        private static readonly char[,] PlayerText = {  { ' ', 'o', ' ', ' ' },
                                                        { '-', ')', ')', '-' },
                                                        { ' ', '|', '\\', ' ' } };
        public Paracrobunus(int x, int y, IModel model) : base(new Sprite(PlayerText), x, y, model)
        {

        }

        public override bool isSquareFree(int x, int y) {
            return Model.World.GetSquare(x, y).Traversable;
        }
    }
}
