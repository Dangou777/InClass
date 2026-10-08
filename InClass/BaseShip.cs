using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InClass
{
    internal class BaseShip
    {
        private int counter;
        protected int move;
        public BaseShip(int i)
        {
            Console.WriteLine("BaseShip constrctur "+i);
        }
        public virtual string Move(int distance)
        {
            counter++;
            return string.Format("baseship moved {0}", counter);
        }

    }
}
