﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling_Salesman
{
    static class RandomNumber
    {
        private static Random random = new Random();
        public static int RandoNumber(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
