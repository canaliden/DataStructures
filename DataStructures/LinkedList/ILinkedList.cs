// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILinkedList.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.LinkedList
{
    public interface ILinkedList<T>
    {
        int Count();

        void Remove(T value);

        void RemoveAt(int index);

        void RemoveFirstNode();

        void RemoveLastNode();

        LinkedListNode<T> Find(T value);

        LinkedListNode<T> FindAtIndex(int index);

        LinkedListNode<T> FindFirstNode();

        LinkedListNode<T> FindLastNode();

        void AddAfter(T value, LinkedListNode<T> newNode);

        void AddAfter(LinkedListNode<T> value, LinkedListNode<T> newNode);

        void AddAt(int index, LinkedListNode<T> newNode);

        void AddBefore(T value, LinkedListNode<T> newNode);

        void AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode);

        void AddFirst(LinkedListNode<T> newNode);

        void AddLast(LinkedListNode<T> newNode);

        bool IsEmpty();

        void Reverse();
    }
}