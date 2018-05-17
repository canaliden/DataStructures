// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HeapTree.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.Heap
{
    #region Usings

    using System.Diagnostics;

    #endregion

    /// <summary>
    /// The heap tree.
    /// </summary>
    public class HeapTree
    {
        /// <summary>
        /// The collection.
        /// </summary>
        private readonly int[] collection;

        /// <summary>
        /// The current size.
        /// </summary>
        private int currentSize = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="HeapTree"/> class.
        /// </summary>
        /// <param name="maxSize">
        /// The max size.
        /// </param>
        public HeapTree(int maxSize = 100)
        {
            this.collection = new int[maxSize];
        }

        /// <summary>
        /// The delete root.
        /// </summary>
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

        /// <summary>
        /// The display.
        /// </summary>
        public void Display()
        {
            for (int i = 1; i <= this.currentSize; i++)
            {
                Debug.Write($"{this.collection[i]}\t");
            }
        }

        /// <summary>
        /// The ınsert.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
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

        /// <summary>
        /// The search.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
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
    }
}