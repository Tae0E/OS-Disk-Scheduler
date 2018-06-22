using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disk_IO
{
    public struct Tracer
    {
        static public int counter = 0;

        public int jobNumber;
        public int jobPosition;
        public int jobMovement;
        public int accumulateTime;
        public double total;        //전체실행시간

        public Tracer(int jobPosition, int jobMovement, int accumulateTime, double total)
        {
            this.jobNumber = counter++;
            this.jobPosition = jobPosition;
            this.jobMovement = jobMovement;
            this.accumulateTime = accumulateTime;
            this.total=total;
        }
    }
}
