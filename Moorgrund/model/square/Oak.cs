using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.square
{
    class Oak : Tree
    {
        private static readonly char[,] treeText = {   { ' ', '@', '@', ' ' },
                                                        { '@', '@', '@', '@' },
                                                        { ' ', '▒', '▒', ' ' } };

        public Oak() : base(treeText)
        {

        }
    }
}
