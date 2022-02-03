using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.square
{
    class Fir : Tree
    {
        private static readonly char[,] treeText = {   { ' ', '/', '\\', ' ' },
                                                        { '/', '_', '_', '\\' },
                                                        { ' ', '▒', '▒', ' ' } };

        public Fir() : base(treeText)
        {

        }
    }
}
