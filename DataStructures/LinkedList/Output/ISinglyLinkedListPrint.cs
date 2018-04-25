// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISinglyLinkedListPrint.cs" company="Ali Can">
//   Free to use
// </copyright>
// <summary>
//   
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.LinkedList.Output
{
    using DataStructures.LinkedList.SinglyLinked;

    /// <summary>
    /// The Print interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface ISinglyLinkedListPrint<T>
    {
        /// <summary>
        /// The print.
        /// </summary>
        /// <param name="list">
        /// The list.
        /// </param>
        void Print(ISinglyLinkedList<T> list);
    }
}