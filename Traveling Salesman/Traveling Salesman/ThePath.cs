using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling_Salesman
{
    class ThePath
    {
        private Random random;
        private string[] aPath;

        public ThePath()
        {
            random = new Random();
            aPath = new string[12];
            createPath();
        }

        private void createPath()
        {
            string[] basePath = new string[12];
            basePath[0] = "100000000000";
            basePath[1] = "010000000000";
            basePath[2] = "001000000000";
            basePath[3] = "000100000000";
            basePath[4] = "000010000000";
            basePath[5] = "000001000000";
            basePath[6] = "000000100000";
            basePath[7] = "000000010000";
            basePath[8] = "000000001000";
            basePath[9] = "000000000100";
            basePath[10] = "000000000010";
            basePath[11] = "000000000001";
            for (int i = 0; i < 12; i++)
            {
                int rand = RandomNumber.RandoNumber(0,12);
                aPath[i] = basePath[rand];
            }
        }

        public string[] APath
        {
            get
            {
                return aPath;
            }
        }


    }
}
