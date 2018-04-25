// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DoublyLinkedList.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.LinkedList.DoublyLinked
{
    #region Usings

    using System;

    using DataStructures.LinkedList.Node;

    #region Usings

    #endregion

    #endregion

    /// <summary>
    /// The doubly linked list.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public class DoublyLinkedList<T> : IDoublyLinkedList<T>
    {
        /// <summary>
        /// The start.
        /// </summary>
        private DoublyLinkedListNode<T> start;

        /// <summary>
        /// The add after.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        public void AddAfter(T value, DoublyLinkedListNode<T> newNode)
        {
            this.AddAfter(new DoublyLinkedListNode<T>(value), newNode);
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
        public void AddAfter(DoublyLinkedListNode<T> value, DoublyLinkedListNode<T> newNode)
        {
            // check for null
            this.CheckNull(newNode);

            // Find and execute action
            this.Find(
                value,
                (t) =>
                    {
                        newNode.NextNode = t.node.NextNode;
                        newNode.PrevNode = t.node;
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
        public void AddAt(int index, DoublyLinkedListNode<T> newNode)
        {
            // check for null
            this.CheckNull(newNode);

            // find at index and execute the action
            var node = this.FindAtIndex(
                index,
                (t) =>
                    {
                        if (t.node.PrevNode == null)
                        {
                            newNode.NextNode = t.node;
                            t.node.PrevNode = newNode;
                            this.start = newNode;
                        }
                        else
                        {
                            newNode.NextNode = t.node;
                            newNode.PrevNode = t.node.PrevNode;
                            t.node.PrevNode.NextNode = newNode;
                            t.node.PrevNode = newNode;
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
        public void AddBefore(T value, DoublyLinkedListNode<T> newNode)
        {
            this.AddBefore(new DoublyLinkedListNode<T>(value), newNode);
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
        public void AddBefore(DoublyLinkedListNode<T> node, DoublyLinkedListNode<T> newNode)
        {
            // check for null
            this.CheckNull(newNode);

            // find the value and execute the action
            this.Find(
                node,
                (t) =>
                    {
                        if (t.node.PrevNode == null)
                        {
                            newNode.NextNode = t.node;
                            t.node.PrevNode = newNode;
                            this.start = newNode;
                        }
                        else
                        {
                            newNode.NextNode = t.node;
                            newNode.PrevNode = t.node.PrevNode;
                            t.node.PrevNode = newNode;
                            t.node.PrevNode.NextNode = newNode;
                        }
                    });
        }

        /// <summary>
        /// The add first.
        /// </summary>
        /// <param name="newNode">
        /// The new node.
        /// </param>
        public void AddFirst(DoublyLinkedListNode<T> newNode)
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
        public void AddLast(DoublyLinkedListNode<T> newNode)
        {
            // check for null
            this.CheckNull(newNode);

            // find the last node and execute the action
            var node = this.FindLastNode(
                (t) =>
                    {
                        t.node.NextNode = newNode;
                        newNode.PrevNode = t.node;
                    });

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
            DoublyLinkedListNode<T> currentNode = this.start;
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
        /// The <see cref="DoublyLinkedListNode"/>.
        /// </returns>
        public DoublyLinkedListNode<T> Find(T value)
        {
            var matchedNode = this.Find(new DoublyLinkedListNode<T>(value), null);
            return matchedNode;
        }

        /// <summary>
        /// The find at ındex.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <returns>
        /// The <see cref="DoublyLinkedListNode"/>.
        /// </returns>
        public DoublyLinkedListNode<T> FindAtIndex(int index)
        {
            var nodeAtIndex = this.FindAtIndex(index, null);
            return nodeAtIndex;
        }

        /// <summary>
        /// The find first node.
        /// </summary>
        /// <returns>
        /// The <see cref="DoublyLinkedListNode"/>.
        /// </returns>
        public DoublyLinkedListNode<T> FindFirstNode()
        {
            return this.start;
        }

        /// <summary>
        /// The find last node.
        /// </summary>
        /// <returns>
        /// The <see cref="DoublyLinkedListNode"/>.
        /// </returns>
        public DoublyLinkedListNode<T> FindLastNode()
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
                new DoublyLinkedListNode<T>(value),
                (t) =>
                    {
                        if (t.node.NextNode != null)
                        {
                            t.node.NextNode.PrevNode = t.node.PrevNode;
                        }

                        if (t.node.PrevNode == null)
                        {
                            this.start = t.node.NextNode;
                        }
                        else
                        {
                            t.node.PrevNode.NextNode = t.node.NextNode;
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
                        if (t.node.NextNode != null)
                        {
                            t.node.NextNode.PrevNode = t.node.PrevNode;
                        }

                        if (t.node.PrevNode == null)
                        {
                            this.start = t.node.NextNode;
                        }
                        else
                        {
                            t.node.PrevNode.NextNode = t.node.NextNode;
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
                if (this.start.NextNode != null)
                {
                    this.start.NextNode.PrevNode = null;
                }

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
                        if (t.node.PrevNode == null)
                        {
                            this.start = null;
                        }
                        else
                        {
                            t.node.PrevNode.NextNode = null;
                        }
                    });
        }

        /// <summary>
        /// The check null.
        /// </summary>
        /// <param name="node">
        /// The node.
        /// </param>
        /// <exception cref="Exception">
        /// </exception>
        private void CheckNull(DoublyLinkedListNode<T> node)
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
        /// The <see cref="DoublyLinkedListNode"/>.
        /// </returns>
        private DoublyLinkedListNode<T> Find(
            DoublyLinkedListNode<T> nodeToFind,
            Action<(DoublyLinkedListNode<T> node, int index)> actionToExecute)
        {
            var currentNode = this.start;
            int currentIndex = 0;
            while (currentNode != null)
            {
                if (currentNode.Equals(nodeToFind))
                {
                    actionToExecute?.Invoke((currentNode, currentIndex));
                    return currentNode;
                }

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
        /// The <see cref="DoublyLinkedListNode"/>.
        /// </returns>
        private DoublyLinkedListNode<T> FindAtIndex(
            int index,
            Action<(DoublyLinkedListNode<T> node, int index)> actionToExecute)
        {
            var currentNode = this.start;
            int currentIndex = 0;
            while (currentNode != null)
            {
                if (currentIndex == index)
                {
                    actionToExecute?.Invoke((currentNode, currentIndex));
                    return currentNode;
                }

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
        /// The <see cref="DoublyLinkedListNode"/>.
        /// </returns>
        private DoublyLinkedListNode<T> FindLastNode(Action<(DoublyLinkedListNode<T> node, int index)> actionToExecute)
        {
            var currentNode = this.start;
            int currentIndex = 0;
            while (currentNode?.NextNode != null)
            {
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            if (currentNode != null)
            {
                actionToExecute?.Invoke((currentNode, currentIndex));
            }

            return currentNode;
        }
    }
}