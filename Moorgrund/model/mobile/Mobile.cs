using Moorgrund.model.square;
using Moorgrund.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.mobile
{
    abstract class Mobile : Square, IMobile
    {
        public int X { get; set; }
        public int Y { get; set; }

        public IWorld World { get; set; }

        public Mobile(Sprite sprite, int x, int y, IWorld world) : base(sprite, false)
        {
            X = x;
            Y = y;
            World = world;
        }

        protected bool isSquareFree(int x, int y)
        {
            return World.GetSquare(x, y).Traversable;
        }

        public void MoveDown()
        {
            if (isSquareFree(X, Y + 1))
            {
                Y = Y++;
            }
        }

        public void MoveUp()
        {
            if (isSquareFree(X, Y - 1))
            {
                Y = Y--;
            }
        }

        public void MoveLeft()
        {
            if (isSquareFree(X - 1, Y))
            {
                X = X--;
            }
        }

        public void MoveRight()
        {
            if (isSquareFree(X + 1, Y))
            {
                X = X++;
            }
        }
    }
}
