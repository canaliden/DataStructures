using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Heap
{
    using System.Diagnostics;
    using System.Security.Policy;

    public class HeapTree
    {
        private int[] collection;

        private int currentSize = 0;

        public HeapTree(int maxSize = 100)
        {
            this.collection = new int[maxSize];
        }

        public void Insert(int number)
        {
            this.collection[++this.currentSize] = number;

            int parentIndex = this.currentSize / 2;
            int currentIndex = this.currentSize;
            while (true)
            {
                if (parentIndex == 0)
                {
                    break;
                }

                if (this.collection[currentIndex] > this.collection[parentIndex])
                {
                    var temp = this.collection[currentIndex];
                    this.collection[currentIndex] = this.collection[parentIndex];
                    this.collection[parentIndex] = temp;
                }

                currentIndex = parentIndex;
                parentIndex = parentIndex / 2;
            }
        }

        public void DeleteRoot()
        {
            if (this.currentSize == 0)
            {
                return;
            }

            this.collection[1] = this.collection[this.currentSize];
            this.collection[this.currentSize] = 0;
            this.currentSize--;

            int currentIndex = 1;
            while (true)
            {
                int leftValue = this.collection[2 * currentIndex];
                int rightValue = this.collection[2 * currentIndex + 1];

                if (currentIndex >= this.currentSize)
                {
                    break;
                }

                if (leftValue > rightValue && leftValue > this.collection[currentIndex])
                {
                    var temp = this.collection[currentIndex];
                    this.collection[currentIndex] = leftValue;
                    this.collection[2 * currentIndex] = temp;
                    currentIndex = 2 * currentIndex;
                }
                else if (leftValue < rightValue && rightValue > this.collection[currentIndex])
                {
                    var temp = this.collection[currentIndex];
                    this.collection[currentIndex] = rightValue;
                    this.collection[2 * currentIndex + 1] = temp;
                    currentIndex = 2 * currentIndex + 1;
                }
                else
                {
                    break;
                }
            }
        }

        public int Search(int number)
        {
            for (int i = 1; i <= this.currentSize; i++)
            {
                if (this.collection[i] == number)
                {
                    return i;
                }
            }

            return 0;
        }

        public void Display()
        {
            for (int i = 1; i <= this.currentSize; i++)
            {
                Debug.Write($"{this.collection[i]}\t");
            }
        }
    }
}
