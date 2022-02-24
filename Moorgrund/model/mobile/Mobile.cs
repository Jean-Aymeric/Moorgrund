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
        public IModel Model { get; set; }
        private int _x, _y;
        public int X { get { return _x; } set { if(Model != null) Model.Changed = true; _x = value; } }
        public int Y { get { return _y; } set { if (Model != null) Model.Changed = true; _y = value; } }
        public Direction Direction { get; set; }

        public Mobile(Sprite sprite, int x, int y, IModel model) : base(sprite, false)
        {
            Model = model;
            X = x;
            Y = y;
        }

        abstract public bool isSquareFree(int x, int y);

        public void MoveDown()
        {
            if (isSquareFree(X, Y + 1))
            {
                Y++;
            }
        }

        public void MoveUp()
        {
            if (isSquareFree(X, Y - 1))
            {
                Y--;
            }
        }

        public void MoveLeft()
        {
            if (isSquareFree(X - 1, Y))
            {
                X--;
            }
        }

        public void MoveRight()
        {
            if (isSquareFree(X + 1, Y))
            {
                X++;
            }
        }

        public char getSpriteXY(int x, int y) {
            return Sprite.TextImage[y, x];
        }

        public virtual void Live() {

        }
    }
}
