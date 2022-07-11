using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.CSharp.ConsoleApp
{
    public class CustomStack
    {
        public CustomStack()
        {
            container = new int[10];
        }

        public CustomStack(int size)
        {
            container = new int[size];
        }

        private int[] container;
        private int counter = -1;

        public void Push(int item)
        {
            if (counter < container.Length - 1)
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

    public class CustomStackString
    {
        public CustomStackString()
        {
            container = new string[10];
        }

        public CustomStackString(int size)
        {
            container = new string[size];
        }

        private string[] container;
        private int counter = -1;

        public void Push(string item)
        {
            if (counter < container.Length - 1)
            {
                counter++;
                container[counter] = item;
            }
        }

        public void Pop()
        {
            if (counter >= 0)
            {
                container[counter] = default(string);
                counter--;
            }
        }
    }

    public class CustomStackTemplated<T>
    {
        public CustomStackTemplated()
        {
            container = new T[10];
        }

        public CustomStackTemplated(int size)
        {
            container = new T[size];
        }

        private T[] container;
        private int counter = -1;

        public void Push(T item)
        {
            if (counter < container.Length - 1)
            {
                counter++;
                container[counter] = item;
            }
        }

        public void Pop()
        {
            if (counter >= 0)
            {
                container[counter] = default(T);
                counter--;
            }
        }
    }
}