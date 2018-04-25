// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsolePrint.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.LinkedList.Output
{
    #region Usings

    using System;

    using DataStructures.LinkedList.SinglyLinked;

    #endregion

    /// <summary>
    /// The console print.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public class ConsoleSinglyLinkedListPrint<T> : ISinglyLinkedListPrint<T>
    {
        /// <summary>
        /// The print.
        /// </summary>
        /// <param name="list">
        /// The list.
        /// </param>
        public void Print(ISinglyLinkedList<T> list)
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