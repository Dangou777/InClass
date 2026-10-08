using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass
{
    internal class TransportShip : BaseShip
    {

        public TransportShip(int i):base(5)
        {
            Console.WriteLine("transportship constractur ");
        }
        public override string Move(int distance)
        {
            return string.Format("baseship moved {0}",distance);
        }
        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}
