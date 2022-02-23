using Moorgrund.model.mobile.creature.behaviorMove;
using Moorgrund.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.mobile.creature
{
    class Dragon : Creature
    {
        private static readonly char[,] PlayerText = { { '\'', '^', '\'', ' ' },
                                                        { '/', 'O', '\\', ' ' },
                                                        { ' ', '"', ' ', ' ' } };
        public Dragon(int x, int y, IModel model) : base(new Sprite(PlayerText), x, y, model, new BehaviorWalk())
        {

        }
    }
}
