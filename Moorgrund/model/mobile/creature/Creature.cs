using Moorgrund.model.mobile.creature.behaviorMove;
using Moorgrund.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.mobile.creature
{
    abstract class Creature : Mobile, ICreature
    {
        private BehaviorMove _behaviorMove;
        BehaviorMove BehaviorMove {
            get => _behaviorMove;
            set
            {
                value.Creature = this;
                _behaviorMove = value;
            }
        }

        public Creature(Sprite sprite, int x, int y, IModel model, BehaviorMove behaviorMove) : base(sprite, x, y, model)
        {
            BehaviorMove = behaviorMove;
        }

        public void Move()
        {
            BehaviorMove.Move();
        }

        public override void Live()
        {
            Move();
        }

        public override bool isSquareFree(int x, int y) {
            return Model.World.GetSquare(x, y).Traversable;
        }
    }
}
