// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISinglyLinkedListCycleDetector.cs" company="Ali Can">
//   Free to use
// </copyright>
// <summary>
//   
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.LinkedList.Cycle
{
    using DataStructures.LinkedList.Node;
    using DataStructures.LinkedList.SinglyLinked;

    /// <summary>
    /// The SinglyLinkedListCycleDetector interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface ISinglyLinkedListCycleDetector<T>
    {
        /// <summary>
        /// The find cycle.
        /// </summary>
        /// <param name="linkedList">
        /// The linked list.
        /// </param>
        /// <returns>
        /// The <see cref="LinkedListNode"/>.
        /// </returns>
        SinglyLinkedListNode<T> FindCycle(ISinglyLinkedList<T> linkedList);

        /// <summary>
        /// The has cycle.
        /// </summary>
        /// <param name="linkedList">
        /// The linked list.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool HasCycle(ISinglyLinkedList<T> linkedList);

        /// <summary>
        /// The remove cycle.
        /// </summary>
        /// <param name="linkedList">
        /// The linked list.
        /// </param>
        void RemoveCycle(ISinglyLinkedList<T> linkedList);
    }
}