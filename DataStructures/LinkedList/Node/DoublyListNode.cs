// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DoublyListNode.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.LinkedList.Node
{
    /// <summary>
    /// The doubly linked list node.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public class DoublyLinkedListNode<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DoublyLinkedListNode{T}"/> class.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        public DoublyLinkedListNode(T value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the next node.
        /// </summary>
        public DoublyLinkedListNode<T> NextNode { get; internal set; }

        /// <summary>
        /// Gets the prev node.
        /// </summary>
        public DoublyLinkedListNode<T> PrevNode { get; internal set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        public T Value { get; }

        /// <summary>
        /// The equals.
        /// </summary>
        /// <param name="obj">
        /// The obj.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj is DoublyLinkedListNode<T>)
            {
                return this.Value.Equals(((DoublyLinkedListNode<T>)obj).Value);
            }

            return false;
        }

        /// <summary>
        /// The get hash code.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}