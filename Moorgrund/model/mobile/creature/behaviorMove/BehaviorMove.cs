using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.mobile.creature.behaviorMove
{
    abstract class BehaviorMove
    {
        public Creature Creature { get; set; }
        public abstract void Move();
    }
}
