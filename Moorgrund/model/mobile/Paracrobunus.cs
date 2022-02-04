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
    }
}
