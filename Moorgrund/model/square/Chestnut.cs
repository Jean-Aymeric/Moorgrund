using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.square
{
    class Chestnut : Tree
    {
        private static readonly char[,] treeText = {   { ' ', '/', '\\', ' ' },
                                                        { '/', '°', '°', '\\' },
                                                        { ' ', '▒', '▒', ' ' } };

        public Chestnut() : base(treeText)
        {

        }
    }
}
