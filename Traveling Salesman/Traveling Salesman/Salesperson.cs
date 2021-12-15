using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling_Salesman
{
    class Salesperson
    {
        private long[] pathBS;
        private int fitnessValue;
        private ThePath path = new ThePath();

        public Salesperson()
        {
            pathBS = path.APath;
            fitnessValue = 0;
        }

        public long[] PathBS
        {
            get
            {
                return pathBS;
            }
            set
            {
                pathBS = value;
            }
        }

        public int FitnessValue
        {
            get
            {
                return fitnessValue;
            }
            set
            {
                fitnessValue = value;
            }
        }

        public int CompareTo(Salesperson salesperson)
        {
            if(salesperson == null)
            {
                return 1;
            }
            else
            {
                return this.fitnessValue.CompareTo(salesperson.fitnessValue);
            }
        }
            
    }
}
