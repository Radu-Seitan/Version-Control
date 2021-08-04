using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyCollection<T>
    {
        private readonly int maxSize;
        private int count;
        private T[] elements;

        public MyCollection(int maxSize = 100)
        {
            this.maxSize = maxSize;
            count = 0;
            elements = new T[maxSize];
        }

        public void Add(T param)
        {
            if(count >= maxSize)
            {
                throw new InvalidOperationException("Capacity reached");
            }
            elements[count++] = param;
        }

        public T GetItemAtIndex(int index)
        {
            if(index >= count)
            {
                throw new InvalidOperationException("Invalid index");
            }
            else
            {
                return elements[index];
            }
        }

        public void SetItemAtIndex(int index, T el)
        {
            if (index >= count)
            {
                throw new InvalidOperationException("Invalid index");
            }
            else
            {
                elements[index] = el;
            }
        }

        public void Swap(int index1, int index2)
        {
            T auxElement = elements[index1];
            elements[index1] = elements[index2];
            elements[index2] = auxElement;
        }

        public void Swap(T firstElement, T secondElement)
        {
            Swap(Array.FindIndex<T>(elements, e => e.Equals(firstElement)), Array.FindIndex<T>(elements, e => e.Equals(secondElement)));
        }

        public override string ToString()
        {
            string result = "";
            for(int i = 0; i < count; i++)
            {
                result += elements[i] + " ";
            }
            return result;
        }
    }
}
