using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.CSharp.ConsoleApp
{
    public class CustomStack
    {
        private int[] container = new int[5];
        private int counter = -1;

        public void Push(int item)
        {
            if (counter < 4)
            {
                counter++;
                container[counter] = item;
            }
        }

        public void Pop()
        {
            if (counter >= 0)
            {
                container[counter] = default(int);
                counter--;
            }
        }
    }
}