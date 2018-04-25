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
        /// The front.
        /// </summary>
        private SinglyLinkedListNode<T> front;

        /// <summary>
        /// The clear.
        /// </summary>
        public void Clear()
        {
            this.last = null;
            this.front = null;
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

            var count = 0;
            var currentNode = this.front;
            while (currentNode != null)
            {
                count++;
                currentNode = currentNode.NextNode;
            }

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
            if (this.front == null)
            {
                return default(T);
            }

            // Check if only one item in the queue
            T val = this.front.Value;

            this.front = this.front.NextNode;
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
                this.front = newNode;
            }
            else
            {
                this.last.NextNode = newNode;
                this.last = newNode;
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
            if (this.front == null)
            {
                return default(T);
            }

            // Check if only one item in the queue
            T val = this.front.Value;
            return val;
        }
    }
}