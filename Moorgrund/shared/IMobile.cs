using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.shared
{
    interface IMobile : ISquare
    {
        int X { get; set; }
        int Y { get; set; }

        void MoveDown();
        void MoveLeft();
        void MoveRight();
        void MoveUp();
        char getSpriteXY(int x, int y);
        bool isSquareFree(int x, int y);
        void Live();
    }
}
