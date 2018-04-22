// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILinkedListCycleDetector.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.LinkedList
{
    /// <summary>
    /// The LinkedListCycleDetector interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface ILinkedListCycleDetector<T>
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
        LinkedListNode<T> FindCycle(ILinkedList<T> linkedList);

        /// <summary>
        /// The has cycle.
        /// </summary>
        /// <param name="linkedList">
        /// The linked list.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool HasCycle(ILinkedList<T> linkedList);

        /// <summary>
        /// The remove cycle.
        /// </summary>
        /// <param name="linkedList">
        /// The linked list.
        /// </param>
        void RemoveCycle(ILinkedList<T> linkedList);
    }
}