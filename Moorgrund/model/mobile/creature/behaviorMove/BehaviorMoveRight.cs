using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.mobile.creature.behaviorMove
{
    class BehaviorMoveRight : BehaviorMove
    {
        public override void Move()
        {
            Creature.MoveRight();
        }
    }
}
