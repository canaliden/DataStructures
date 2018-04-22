// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SinglyLinkedList.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.LinkedList
{
    #region Usings

    using System;

    #endregion

    /// <summary>
    /// The singly linked list.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public class SinglyLinkedList<T> : ILinkedList<T>
    {
        /// <summary>
        /// The start.
        /// </summary>
        private LinkedListNode<T> start;

        /// <summary>
        /// The add after.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        public void AddAfter(T value, LinkedListNode<T> newNode)
        {
            this.AddAfter(new SinglyListNode<T>(value), newNode);
        }

        /// <summary>
        /// The add after.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        public void AddAfter(LinkedListNode<T> value, LinkedListNode<T> newNode)
        {
            // check for null
            this.CheckNull(newNode);

            // Find and execute action
            this.Find(
                value,
                (t) =>
                    {
                        newNode.NextNode = t.node.NextNode;
                        t.node.NextNode = newNode;
                    });
        }

        /// <summary>
        /// The add at.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        public void AddAt(int index, LinkedListNode<T> newNode)
        {
            // check for null
            this.CheckNull(newNode);

            // find at index and execute the action
            var node = this.FindAtIndex(
                index,
                (t) =>
                    {
                        if (t.prevNode == null)
                        {
                            newNode.NextNode = t.node;
                            this.start = newNode;
                        }
                        else
                        {
                            newNode.NextNode = t.prevNode.NextNode;
                            t.prevNode.NextNode = newNode;
                        }
                    });

            if (node == null)
            {
                this.start = newNode;
            }
        }

        /// <summary>
        /// The add before.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        public void AddBefore(T value, LinkedListNode<T> newNode)
        {
            this.AddBefore(new SinglyListNode<T>(value), newNode);
        }

        /// <summary>
        /// The add before.
        /// </summary>
        /// <param name="node">
        /// The node.
        /// </param>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        public void AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
        {
            // check for null
            this.CheckNull(newNode);

            // find the value and execute the action
            this.Find(
                node,
                (t) =>
                    {
                        if (t.prevNode == null)
                        {
                            newNode.NextNode = t.node;
                            this.start = newNode;
                        }
                        else
                        {
                            newNode.NextNode = t.prevNode.NextNode;
                            t.prevNode.NextNode = newNode;
                        }
                    });
        }

        /// <summary>
        /// The add first.
        /// </summary>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        public void AddFirst(LinkedListNode<T> newNode)
        {
            // check for null
            this.CheckNull(newNode);

            // insert at first place
            this.AddAt(0, newNode);
        }

        /// <summary>
        /// The add last.
        /// </summary>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        public void AddLast(LinkedListNode<T> newNode)
        {
            // check for null
            this.CheckNull(newNode);

            // find the last node and execute the action
            var node = this.FindLastNode((t) => { t.node.NextNode = newNode; });

            if (node == null)
            {
                this.start = newNode;
            }
        }

        /// <summary>
        /// The count.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int Count()
        {
            if (this.IsEmpty())
            {
                return 0;
            }

            int index = 1;
            LinkedListNode<T> currentNode = this.start;
            while (currentNode.NextNode != null)
            {
                index++;
                currentNode = currentNode.NextNode;
            }

            return index;
        }

        /// <summary>
        /// The find.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="LinkedListNode"/>.
        /// </returns>
        public LinkedListNode<T> Find(T value)
        {
            var matchedNode = this.Find(new SinglyListNode<T>(value), null);
            return matchedNode;
        }

        /// <summary>
        /// The find at ındex.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <returns>
        /// The <see cref="LinkedListNode"/>.
        /// </returns>
        public LinkedListNode<T> FindAtIndex(int index)
        {
            var nodeAtIndex = this.FindAtIndex(index, null);
            return nodeAtIndex;
        }

        /// <summary>
        /// The find first node.
        /// </summary>
        /// <returns>
        /// The <see cref="LinkedListNode"/>.
        /// </returns>
        public LinkedListNode<T> FindFirstNode()
        {
            return this.start;
        }

        /// <summary>
        /// The find last node.
        /// </summary>
        /// <returns>
        /// The <see cref="LinkedListNode"/>.
        /// </returns>
        public LinkedListNode<T> FindLastNode()
        {
            var lastNode = this.FindLastNode(null);
            return lastNode;
        }

        /// <summary>
        /// The ıs empty.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool IsEmpty()
        {
            return this.start == null;
        }

        /// <summary>
        /// The remove.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        public void Remove(T value)
        {
            // find and delete
            this.Find(
                new SinglyListNode<T>(value),
                (t) =>
                    {
                        if (t.prevNode == null)
                        {
                            this.start = t.node.NextNode;
                        }
                        else
                        {
                            t.prevNode.NextNode = t.node.NextNode;
                        }
                    });
        }

        /// <summary>
        /// The remove at.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        public void RemoveAt(int index)
        {
            // find and delete at index
            this.FindAtIndex(
                index,
                (t) =>
                    {
                        if (t.prevNode == null)
                        {
                            this.start = t.node.NextNode;
                        }
                        else
                        {
                            t.prevNode.NextNode = t.node.NextNode;
                        }
                    });
        }

        /// <summary>
        /// The remove first node.
        /// </summary>
        public void RemoveFirstNode()
        {
            if (this.start != null)
            {
                this.start = this.start.NextNode;
            }
        }

        /// <summary>
        /// The remove last node.
        /// </summary>
        public void RemoveLastNode()
        {
            this.FindLastNode(
                t =>
                    {
                        if (t.prevNode == null)
                        {
                            this.start = null;
                        }
                        else
                        {
                            t.prevNode.NextNode = null;
                        }
                    });
        }

        /// <summary>
        /// The reverse.
        /// </summary>
        public void Reverse()
        {
            LinkedListNode<T> prevNode = null;
            LinkedListNode<T> node = this.start;

            while (node != null)
            {
                LinkedListNode<T> nextNode = node.NextNode;
                node.NextNode = prevNode;
                prevNode = node;
                node = nextNode;
            }

            this.start = prevNode;
        }

        /// <summary>
        /// The check null.
        /// </summary>
        /// <param name="node">
        /// The node.
        /// </param>
        /// <exception cref="Exception">
        /// </exception>
        private void CheckNull(LinkedListNode<T> node)
        {
            if (node == null)
            {
                throw new Exception("Node cannot be null");
            }
        }

        /// <summary>
        /// The find.
        /// </summary>
        /// <param name="nodeToFind">
        /// The node to find.
        /// </param>
        /// <param name="actionToExecute">
        /// The action to execute.
        /// </param>
        /// <returns>
        /// The <see cref="LinkedListNode"/>.
        /// </returns>
        private LinkedListNode<T> Find(
            LinkedListNode<T> nodeToFind,
            Action<(LinkedListNode<T> node, LinkedListNode<T> prevNode, int index)> actionToExecute)
        {
            LinkedListNode<T> prevNode = null;
            var currentNode = this.start;
            int currentIndex = 0;
            while (currentNode != null)
            {
                if (currentNode.Equals(nodeToFind))
                {
                    actionToExecute?.Invoke((currentNode, prevNode, currentIndex));
                    return currentNode;
                }

                prevNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            return null;
        }

        /// <summary>
        /// The find at ındex.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <param name="actionToExecute">
        /// The action to execute.
        /// </param>
        /// <returns>
        /// The <see cref="LinkedListNode"/>.
        /// </returns>
        private LinkedListNode<T> FindAtIndex(
            int index,
            Action<(LinkedListNode<T> node, LinkedListNode<T> prevNode, int index)> actionToExecute)
        {
            LinkedListNode<T> prevNode = null;
            var currentNode = this.start;
            int currentIndex = 0;
            while (currentNode != null)
            {
                if (currentIndex == index)
                {
                    actionToExecute?.Invoke((currentNode, prevNode, currentIndex));
                    return currentNode;
                }

                prevNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            return null;
        }

        /// <summary>
        /// The find last node.
        /// </summary>
        /// <param name="actionToExecute">
        /// The action to execute.
        /// </param>
        /// <returns>
        /// The <see cref="LinkedListNode"/>.
        /// </returns>
        private LinkedListNode<T> FindLastNode(
            Action<(LinkedListNode<T> node, LinkedListNode<T> prevNode, int index)> actionToExecute)
        {
            LinkedListNode<T> prevNode = null;
            var currentNode = this.start;
            int currentIndex = 0;
            while (currentNode?.NextNode != null)
            {
                prevNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            if (currentNode != null)
            {
                actionToExecute?.Invoke((currentNode, prevNode, currentIndex));
            }

            return currentNode;
        }
    }
}