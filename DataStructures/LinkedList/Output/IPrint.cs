// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPrint.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.LinkedList
{
    /// <summary>
    /// The Print interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface IPrint<T>
    {
        /// <summary>
        /// The print.
        /// </summary>
        /// <param name="list">
        /// The list.
        /// </param>
        void Print(ILinkedList<T> list);
    }
}