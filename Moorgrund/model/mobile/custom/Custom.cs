using Moorgrund.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.mobile.custom {
    abstract class Custom : IMobile {
        protected IMobile Mobile { get; }

        public int X { get => Mobile.X; set => Mobile.X = value; }
        public int Y { get => Mobile.Y; set => Mobile.Y = value; }
        public ISprite Sprite { get => Mobile.Sprite; set => Mobile.Sprite = value; }
        public bool Traversable { get => Mobile.Traversable; set => Mobile.Traversable = value; }

        public Custom(IMobile mobile) {
            Mobile = mobile;
        }

        public char getSpriteXY(int x, int y) {
            return getSpriteXYDecorated(x, y);
        }

        protected abstract char getSpriteXYDecorated(int x, int y);

        public void MoveDown() {
            Mobile.MoveDown();
        }

        public void MoveLeft() {
            Mobile.MoveLeft();
        }

        public void MoveRight() {
            Mobile.MoveRight();
        }

        public void MoveUp() {
            Mobile.MoveUp();
        }

        public void Live() {
            Mobile.Live();
        }

        public virtual bool isSquareFree(int x, int y) {
            return Mobile.isSquareFree(x, y);
        }
    }
}
