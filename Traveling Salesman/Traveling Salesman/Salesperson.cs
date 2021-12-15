using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling_Salesman
{
    class Salesperson : IComparable<Salesperson>
    {
        private string[] pathBS;
        private int fitnessValue;
        private ThePath path;

        public Salesperson()
        {
            path = new ThePath();
            pathBS = path.APath;
            fitnessValue = 0;
        }

        public string[] PathBS
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
            if(this.fitnessValue > salesperson.FitnessValue)
            {
                return -1;
            }
            else if(this.fitnessValue == salesperson.fitnessValue)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
            
    }
}
