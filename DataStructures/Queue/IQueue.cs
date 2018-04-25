// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQueue.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.Queue
{
    /// <summary>
    /// The Queue interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface IQueue<T>
    {
        /// <summary>
        /// The clear.
        /// </summary>
        void Clear();

        /// <summary>
        /// The count.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        int Count();

        /// <summary>
        /// The dequeue.
        /// </summary>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        T Dequeue();

        /// <summary>
        /// The enqueue.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        void Enqueue(T item);

        /// <summary>
        /// The peek.
        /// </summary>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        T Peek();
    }
}