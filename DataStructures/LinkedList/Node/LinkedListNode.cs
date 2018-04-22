// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedListNode.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.LinkedList
{
    /// <summary>
    /// The linked list node.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public abstract class LinkedListNode<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedListNode{T}"/> class.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        public LinkedListNode(T value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the next node.
        /// </summary>
        public LinkedListNode<T> NextNode { get; internal set; }

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
            if (obj is LinkedListNode<T>)
            {
                return this.Value.Equals(((LinkedListNode<T>)obj).Value);
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