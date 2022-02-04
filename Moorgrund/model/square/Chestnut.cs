using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.square
{
    class Chestnut : Tree
    {
        private static readonly char[,] treeText = {   { ' ', 'o', 'o', ' ' },
                                                        { 'o', 'O', 'O', 'o' },
                                                        { '°', '▒', '▒', '°' } };

        public Chestnut() : base(treeText)
        {

        }
    }
}
