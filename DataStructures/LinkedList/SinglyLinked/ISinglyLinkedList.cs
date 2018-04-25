// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISinglyLinkedList.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.LinkedList.SinglyLinked
{
    using DataStructures.LinkedList.Node;

    /// <summary>
    /// The LinkedList interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface ISinglyLinkedList<T>
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
        void AddAfter(T value ,   SinglyLinkedListNode<T> newNode);

        /// <summary>
        /// The add after.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        void AddAfter(SinglyLinkedListNode<T> value, SinglyLinkedListNode<T> newNode);

        /// <summary>
        /// The add at.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        void AddAt(int index, SinglyLinkedListNode<T> newNode);

        /// <summary>
        /// The add before.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        void AddBefore(T value, SinglyLinkedListNode<T> newNode);

        /// <summary>
        /// The add before.
        /// </summary>
        /// <param name="node">
        /// The node.
        /// </param>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        void AddBefore(SinglyLinkedListNode<T> node, SinglyLinkedListNode<T> newNode);

        /// <summary>
        /// The add first.
        /// </summary>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        void AddFirst(SinglyLinkedListNode<T> newNode);

        /// <summary>
        /// The add last.
        /// </summary>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        void AddLast(SinglyLinkedListNode<T> newNode);

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
        /// The <see cref="SinglyLinkedListNode"/>.
        /// </returns>
        SinglyLinkedListNode<T> Find(T value);

        /// <summary>
        /// The find at ındex.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <returns>
        /// The <see cref="SinglyLinkedListNode"/>.
        /// </returns>
        SinglyLinkedListNode<T> FindAtIndex(int index);

        /// <summary>
        /// The find first node.
        /// </summary>
        /// <returns>
        /// The <see cref="SinglyLinkedListNode"/>.
        /// </returns>
        SinglyLinkedListNode<T> FindFirstNode();

        /// <summary>
        /// The find last node.
        /// </summary>
        /// <returns>
        /// The <see cref="SinglyLinkedListNode"/>.
        /// </returns>
        SinglyLinkedListNode<T> FindLastNode();

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