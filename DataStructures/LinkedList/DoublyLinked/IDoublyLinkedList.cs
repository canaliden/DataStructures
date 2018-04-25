

namespace DataStructures.LinkedList.DoublyLinked
{
    using DataStructures.LinkedList.Node;

    public interface IDoublyLinkedList<T>
    {
        void AddAfter(T value ,    DoublyLinkedListNode<T> newNode);

        void AddAfter(DoublyLinkedListNode<T> value, DoublyLinkedListNode<T> newNode);

        void AddAt(int index, DoublyLinkedListNode<T> newNode);

        void AddBefore(T value, DoublyLinkedListNode<T> newNode);

        void AddBefore(DoublyLinkedListNode<T> node, DoublyLinkedListNode<T> newNode);

        void AddFirst(DoublyLinkedListNode<T> newNode);

        void AddLast(DoublyLinkedListNode<T> newNode);

        int Count();

        DoublyLinkedListNode<T> Find(T value);

        DoublyLinkedListNode<T> FindAtIndex(int index);

        DoublyLinkedListNode<T> FindFirstNode();

        DoublyLinkedListNode<T> FindLastNode();

        bool IsEmpty();

        void Remove(T value);

        void RemoveAt(int index);

        void RemoveFirstNode();

        void RemoveLastNode();
    }
}