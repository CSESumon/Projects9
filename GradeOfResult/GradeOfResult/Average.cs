using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeOfResult
{
    class Average
    {
        private double physics;

        public double Physics
        {
            get { return physics; }
            set { physics = value; }
        }
        private double chemistry;

        public double Chemistry
        {
            get { return chemistry; }
            set { chemistry = value; }
        }
        private double math;

        public double Math
        {
            get { return math; }
            set { math = value; }
        }

        private double avg;
        public double Avg
        {
            get { return avg; }
            set { avg = value; }
        }

        public double GetAvg()
        {
            return Avg = (chemistry + physics + math)/3;

        }
        
    }
}
