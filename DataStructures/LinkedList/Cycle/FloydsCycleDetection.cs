﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FloydsCycleDetection.cs" company="Ali Can">
//   Free to use
//   Hare & Tortoise/Floyd's Cycle Detection Algorithm Implemented here
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.LinkedList.Cycle
{
    using DataStructures.LinkedList.Node;
    using DataStructures.LinkedList.SinglyLinked;

    /// <summary>
    /// The floyds cycle detection.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public class FloydsCycleDetection<T> : ISinglyLinkedListCycleDetector<T>
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
        public SinglyLinkedListNode<T> FindCycle(ISinglyLinkedList<T> linkedList)
        {
            var firstNode = linkedList.FindFirstNode();
            SinglyLinkedListNode<T> fast = firstNode, slow = firstNode;
            if (fast?.NextNode == null)
            {
                return null;
            }

            while (fast?.NextNode != null)
            {
                fast = fast.NextNode.NextNode;
                slow = slow.NextNode;

                if (slow == fast)
                {
                    return slow;
                }
            }

            return null;
        }
         

        /// <summary>
        /// The has cycle.
        /// </summary>
        /// <param name="linkedList">
        /// The linked list.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool HasCycle(ISinglyLinkedList<T> linkedList)
        {
            var node = this.FindCycle(linkedList);
            return node != null;
        }

        /// <summary>
        /// The remove cycle.
        /// </summary>
        /// <param name="linkedList">
        /// The linked list.
        /// </param>
        public void RemoveCycle(ISinglyLinkedList<T> linkedList)
        {
            var node = this.FindCycle(linkedList);
            if (node == null)
            {
                return;
            }

            // find the length of the cycle
            int lengthOfCycle = 0;
            SinglyLinkedListNode<T> fromMeetPoint = node;
            do
            {
                lengthOfCycle++;
                fromMeetPoint = fromMeetPoint.NextNode;
            }
            while (fromMeetPoint != node);

            // Find the length of the remaining list
            int lengthOfRemList = 0;
            fromMeetPoint = node;
            var fromStart = linkedList.FindFirstNode();
            do
            {
                lengthOfRemList++;
                fromStart = fromStart.NextNode;
                fromMeetPoint = fromMeetPoint.NextNode;
            }
            while (fromStart != fromMeetPoint);

            var lengthOfWholeList = lengthOfCycle + lengthOfRemList;

            // fix the cycle
            fromStart = linkedList.FindFirstNode();
            for (int i = 0; i < lengthOfWholeList - 1; i++)
            {
                fromStart = fromStart.NextNode;
            }

            fromStart.NextNode = null;
        }
    }
}