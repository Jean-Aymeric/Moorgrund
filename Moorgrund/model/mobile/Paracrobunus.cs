﻿using Moorgrund.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moorgrund.model.mobile
{
    class Paracrobunus : Mobile
    {
        private static readonly char[,] PlayerText = {   { ' ', ' ', 'o', ' ' },
                                                        { ' ', '-', '0', '-' },
                                                        { ' ', ' ', '^', ' ' } };
        public Paracrobunus(int x, int y, IWorld world) : base(new Sprite(PlayerText), x, y, world)
        {

        }
    }
}
