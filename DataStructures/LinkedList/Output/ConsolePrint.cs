// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsolePrint.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.LinkedList
{
    #region Usings

    using System;

    #endregion

    /// <summary>
    /// The console print.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public class ConsolePrint<T> : IPrint<T>
    {
        /// <summary>
        /// The print.
        /// </summary>
        /// <param name="list">
        /// The list.
        /// </param>
        public void Print(ILinkedList<T> list)
        {
            if (list.IsEmpty())
            {
                Console.WriteLine("List is empty");
                return;
            }

            Console.WriteLine("List contains: ");

            var currentNode = list.FindFirstNode();
            while (currentNode != null)
            {
                Console.Write(currentNode.Value);
                currentNode = currentNode.NextNode;
            }

            Console.WriteLine(string.Empty);
        }
    }
}