using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling_Salesman
{
    class ThePath
    {
        private Random random = new Random();
        private long[] aPath = new long[12];

        public ThePath()
        {
            createPath();
        }

        private void createPath()
        {
            long[] basePath = new long[12];
            basePath[0] = 100000000000;
            basePath[1] = 010000000000;
            basePath[2] = 001000000000;
            basePath[3] = 000100000000;
            basePath[4] = 000010000000;
            basePath[5] = 000001000000;
            basePath[6] = 000000100000;
            basePath[7] = 000000010000;
            basePath[8] = 000000001000;
            basePath[9] = 000000000100;
            basePath[10] = 000000000010;
            basePath[11] = 000000000001;
            for (int i = 0; i < 12; i++)
            {
                int rand = random.Next(0, 12);
                aPath[i] = basePath[rand];
            }
        }

        public long[] APath
        {
            get
            {
                return aPath;
            }
        }


    }
}
