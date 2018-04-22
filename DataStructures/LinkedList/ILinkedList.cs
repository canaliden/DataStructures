namespace DataStructures.LinkedList
{
    public interface ILinkedList<T>
    {
        int Count();
        void Delete(T value);
        void DeleteAt(int index);
        void DeleteFirstNode();
        void DeleteLastNode();
        Node<T> Find(T value);
        Node<T> FindAtIndex(int index);
        Node<T> FindFirstNode();
        Node<T> FindLastNode();
        bool HasCycle();
        void InsertAfter(T value, Node<T> newNode);
        void InsertAfter(Node<T> value, Node<T> newNode);
        void InsertAt(int index, Node<T> newNode);
        void InsertBefore(T value, Node<T> newNode);
        void InsertBefore(Node<T> node, Node<T> newNode);
        void InsertFirst(Node<T> newNode);
        void InsertLast(Node<T> newNode);
        bool IsEmpty();
        void Print();
        void RemoveCycle();
        void Reverse();
    }
}