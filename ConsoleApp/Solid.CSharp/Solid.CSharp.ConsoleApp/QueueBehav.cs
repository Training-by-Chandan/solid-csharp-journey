using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.CSharp.ConsoleApp
{
    public class Queue
    {
        private int[] container = new int[5];
        private int c = -1;

        public void enqueue(int item)
        {
            if (c < 4)
            {
                c++;
                container[c] = item;
            }
        }

        public void dequeue()
        {
            if (c >= 0)
            {
                int i;
                container[0] = default(int);

                for (i = 0; i < c; i++)
                {
                    container[i] = container[i + 1];
                }
                container[i] = 0;
                c--;
            }
        }
    }
}