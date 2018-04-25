// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SinglyLinkedListNode.cs" company="Ali Can">
//   Free to use
// </copyright>
// <summary>
//   
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.LinkedList.Node
{
    /// <summary>
    /// The linked list node.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public class SinglyLinkedListNode<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedListNode{T}"/> class.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        public SinglyLinkedListNode(T value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the next node.
        /// </summary>
        public SinglyLinkedListNode<T> NextNode { get; internal set; }

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
            if (obj is SinglyLinkedListNode<T>)
            {
                return this.Value.Equals(((SinglyLinkedListNode<T>)obj).Value);
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