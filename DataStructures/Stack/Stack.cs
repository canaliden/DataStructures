// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stack.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.Stack
{
    #region Usings

    using DataStructures.LinkedList.Node;

    #endregion

    /// <summary>
    /// The stack.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public class Stack<T> : IStack<T>
    {
        /// <summary>
        /// The last node.
        /// </summary>
        private DoublyLinkedListNode<T> lastNode;

        /// <summary>
        /// The clear.
        /// </summary>
        public void Clear()
        {
            this.lastNode = null;
        }

        /// <summary>
        /// The count.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int Count()
        {
            if (this.lastNode == null)
            {
                return 0;
            }

            int currentIndex = 0;
            var currentNode = this.lastNode;
            while (currentNode != null)
            {
                currentIndex++;
                currentNode = currentNode.PrevNode;
            }

            return currentIndex;
        }

        /// <summary>
        /// The peek.
        /// </summary>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        public T Peek()
        {
            if (this.lastNode == null)
            {
                return default(T);
            }

            var value = this.lastNode.Value;
            return value;
        }

        /// <summary>
        /// The pop.
        /// </summary>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        public T Pop()
        {
            if (this.lastNode == null)
            {
                return default(T);
            }

            var currentLastNode = this.lastNode;
            this.lastNode = currentLastNode.PrevNode;

            if (this.lastNode != null)
            {
                this.lastNode.NextNode = null;
                currentLastNode.PrevNode = null;
            }

            return currentLastNode.Value;
        }

        /// <summary>
        /// The push.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        public void Push(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);

            if (this.lastNode == null)
            {
                this.lastNode = newNode;
            }
            else
            {
                newNode.PrevNode = this.lastNode;
                this.lastNode.NextNode = newNode;
                this.lastNode = newNode;
            }
        }
    }
}