﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damka
{
    internal class Square
    {
        private Checker checker;

        public Square(bool color)
        {
            checker = new Checker(color);
        }
    }
}
