// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Queue.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.Queue
{
    #region Usings

    using System;

    using DataStructures.LinkedList.Node;

    #endregion

    /// <summary>
    /// The queue.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public class Queue<T> : IQueue<T>
    {
        /// <summary>
        /// The last.
        /// </summary>
        private SinglyLinkedListNode<T> last;

        /// <summary>
        /// The clear.
        /// </summary>
        public void Clear()
        {
            this.last = null;
        }

        /// <summary>
        /// The count.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int Count()
        {
            if (this.last == null)
            {
                return 0;
            }

            int count = 0;
            var currentNode = this.last;
            do
            {
                count++;
                currentNode = currentNode.NextNode;
            }
            while (currentNode != this.last);

            return count;
        }

        /// <summary>
        /// The dequeue.
        /// </summary>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        public T Dequeue()
        {
            // no item in queue
            if (this.last == null)
            {
                return default(T);
            }

            // Check if only one item in the queue
            T val;
            if (this.last.NextNode == null)
            {
                val = this.last.Value;
                this.last = null;
                return val;
            }

            // take the value at the first position
            val = this.last.NextNode.Value;

            // prevent self-pointing reference
            if (this.last.NextNode.NextNode == this.last)
            {
                this.last.NextNode = null;
            }
            else
            {
                this.last.NextNode = this.last.NextNode.NextNode;
            }

            return val;
        }

        /// <summary>
        /// The enqueue.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        public void Enqueue(T item)
        {
            var newNode = new SinglyLinkedListNode<T>(item);
            if (this.last == null)
            {
                this.last = newNode;
            }
            else
            {
                newNode.NextNode = this.last.NextNode ?? this.last;
                this.last.NextNode = newNode;
            }
        }

        /// <summary>
        /// The peek.
        /// </summary>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        public T Peek()
        {
            // no item in queue
            if (this.last == null)
            {
                return default(T);
            }

            // Check if only one item in the queue
            T val;
            if (this.last.NextNode == null)
            {
                val = this.last.Value;
                return val;
            }

            // take the value at the first position
            val = this.last.NextNode.Value;
            return val;
        }
    }
}