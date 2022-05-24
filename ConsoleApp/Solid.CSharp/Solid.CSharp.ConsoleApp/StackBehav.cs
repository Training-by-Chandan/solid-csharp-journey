using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.CSharp.ConsoleApp
{
    public class StackBehav
    {
        private int c = -1;
        private int[] stack = new int[5];

        public void push(int item)
        {
            if (c < 5)
            {
                c++;
                stack[c] = item;
            }
        }

        public void pop()
        {
            if (c >= 0)
            {
                stack[c] = 0;
                c--;
            }
        }
    }
}