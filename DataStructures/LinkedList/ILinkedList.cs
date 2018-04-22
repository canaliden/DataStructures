// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILinkedList.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.LinkedList
{
    /// <summary>
    /// The LinkedList interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface ILinkedList<T>
    {
        /// <summary>
        /// The add after.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        void AddAfter(T value, LinkedListNode<T> newNode);

        /// <summary>
        /// The add after.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        void AddAfter(LinkedListNode<T> value, LinkedListNode<T> newNode);

        /// <summary>
        /// The add at.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        void AddAt(int index, LinkedListNode<T> newNode);

        /// <summary>
        /// The add before.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        void AddBefore(T value, LinkedListNode<T> newNode);

        /// <summary>
        /// The add before.
        /// </summary>
        /// <param name="node">
        /// The node.
        /// </param>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        void AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode);

        /// <summary>
        /// The add first.
        /// </summary>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        void AddFirst(LinkedListNode<T> newNode);

        /// <summary>
        /// The add last.
        /// </summary>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        void AddLast(LinkedListNode<T> newNode);

        /// <summary>
        /// The count.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        int Count();

        /// <summary>
        /// The find.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="LinkedListNode"/>.
        /// </returns>
        LinkedListNode<T> Find(T value);

        /// <summary>
        /// The find at ındex.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <returns>
        /// The <see cref="LinkedListNode"/>.
        /// </returns>
        LinkedListNode<T> FindAtIndex(int index);

        /// <summary>
        /// The find first node.
        /// </summary>
        /// <returns>
        /// The <see cref="LinkedListNode"/>.
        /// </returns>
        LinkedListNode<T> FindFirstNode();

        /// <summary>
        /// The find last node.
        /// </summary>
        /// <returns>
        /// The <see cref="LinkedListNode"/>.
        /// </returns>
        LinkedListNode<T> FindLastNode();

        /// <summary>
        /// The ıs empty.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool IsEmpty();

        /// <summary>
        /// The remove.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        void Remove(T value);

        /// <summary>
        /// The remove at.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        void RemoveAt(int index);

        /// <summary>
        /// The remove first node.
        /// </summary>
        void RemoveFirstNode();

        /// <summary>
        /// The remove last node.
        /// </summary>
        void RemoveLastNode();

        /// <summary>
        /// The reverse.
        /// </summary>
        void Reverse();
    }
}