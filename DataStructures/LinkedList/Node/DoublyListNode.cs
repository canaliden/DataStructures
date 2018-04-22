// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DoublyListNode.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.LinkedList
{
    /// <summary>
    /// The doubly list node.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public class DoublyListNode<T> : LinkedListNode<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DoublyListNode{T}"/> class.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        public DoublyListNode(T value)
            : base(value)
        {
        }

        /// <summary>
        /// Gets the prev node.
        /// </summary>
        public LinkedListNode<T> PrevNode { get; internal set; }
    }
}