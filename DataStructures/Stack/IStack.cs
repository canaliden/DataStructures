// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IStack.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.Stack
{
    /// <summary>
    /// The Stack interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface IStack<T>
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
        /// The peek.
        /// </summary>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        T Peek();

        /// <summary>
        /// The pop.
        /// </summary>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        T Pop();

        /// <summary>
        /// The push.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        void Push(T value);
    }
}