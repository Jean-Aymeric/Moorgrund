using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.mobile.creature.behaviorMove
{
    class BehaviorWalk : BehaviorMove
    {
        public override void Move()
        {
            Creature.MoveLeft();
        }
    }
}
