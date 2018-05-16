// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BinarySearchTree.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.BinaryTree
{
    #region Usings

    using System.Diagnostics;

    using DataStructures.LinkedList.Node;

    #endregion

    /// <summary>
    /// The binary search tree.
    /// </summary>
    public class BinarySearchTree
    {
        /// <summary>
        /// The root node.
        /// </summary>
        public DoublyLinkedListNode<int> RootNode;

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        public void Delete(int number)
        {
            var node = this.RootNode;
            DoublyLinkedListNode<int> parent = null;
            while (true)
            {
                if (node == null)
                {
                    return;
                }

                if (node.Value == number)
                {
                    break;
                }

                parent = node;
                node = node.Value > number ? node.PrevNode : node.NextNode;
            }

            if (node.PrevNode == null && node.NextNode == null)
            {
                if (parent == null)
                {
                    this.RootNode = null;
                }

                if (parent.Value < node.Value)
                {
                    parent.NextNode = null;
                }
                else
                {
                    parent.PrevNode = null;
                }
            }
            else if (node.PrevNode == null)
            {
                if (parent.Value < node.Value)
                {
                    parent.NextNode = node.NextNode;
                }
                else
                {
                    parent.PrevNode = node.NextNode;
                }
            }
            else if (node.NextNode == null)
            {
                if (parent.Value < node.Value)
                {
                    parent.NextNode = node.PrevNode;
                }
                else
                {
                    parent.PrevNode = node.PrevNode;
                }
            }
            else
            {
                var p = node.NextNode;
                DoublyLinkedListNode<int> pParent = null;
                while (true)
                {
                    if (p.PrevNode == null)
                    {
                        break;
                    }

                    pParent = p;
                    p = p.PrevNode;
                }

                if (pParent != null)
                {
                    pParent.PrevNode = p.NextNode;
                }

                var newNode = new DoublyLinkedListNode<int>(p.Value);
                newNode.PrevNode = node.PrevNode;
                newNode.NextNode = node.NextNode;
                if (parent != null)
                {
                    if (parent.Value > node.Value)
                    {
                        parent.PrevNode = newNode;
                    }
                    else
                    {
                        parent.NextNode = newNode;
                    }
                }
            }
        }

        /// <summary>
        /// The display.
        /// </summary>
        public void Display()
        {
            this.Display(this.RootNode, 0);
        }

        /// <summary>
        /// The display.
        /// </summary>
        /// <param name="node">
        /// The node.
        /// </param>
        /// <param name="level">
        /// The level.
        /// </param>
        public void Display(DoublyLinkedListNode<int> node, int level)
        {
            if (node == null)
            {
                return;
            }

            this.Display(node.NextNode, level + 1);
            Debug.WriteLine("");

            for (int i = 0; i < level; i++)
            {
                Debug.Write("     ");
            }

            Debug.Write(node.Value);

            this.Display(node.PrevNode, level + 1);
        }

        /// <summary>
        /// The get height.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int GetHeight()
        {
            return this.GetHeight(this.RootNode);
        }

        /// <summary>
        /// The ınsert.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        public void Insert(int number)
        {
            var node = this.RootNode;
            while (true)
            {
                if (node == null)
                {
                    this.RootNode = new DoublyLinkedListNode<int>(number);
                    break;
                }

                if (node.Value < number)
                {
                    if (node.NextNode == null)
                    {
                        node.NextNode = new DoublyLinkedListNode<int>(number);
                        break;
                    }

                    node = node.NextNode;
                }
                else if (node.Value > number)
                {
                    if (node.PrevNode == null)
                    {
                        node.PrevNode = new DoublyLinkedListNode<int>(number);
                        break;
                    }

                    node = node.PrevNode;
                }
            }
        }

        /// <summary>
        /// The ıs empty.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool IsEmpty()
        {
            return this.RootNode == null;
        }

        /// <summary>
        /// The search.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <returns>
        /// The <see cref="DoublyLinkedListNode"/>.
        /// </returns>
        public DoublyLinkedListNode<int> Search(int number)
        {
            var node = this.RootNode;
            while (true)
            {
                if (node == null)
                {
                    return null;
                }

                if (node.Value == number)
                {
                    return node;
                }

                node = node.Value > number ? node.PrevNode : node.NextNode;
            }
        }

        /// <summary>
        /// The get height.
        /// </summary>
        /// <param name="node">
        /// The node.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        private int GetHeight(DoublyLinkedListNode<int> node)
        {
            if (node == null)
            {
                return 0;
            }

            var hL = this.GetHeight(node.PrevNode);
            var hR = this.GetHeight(node.NextNode);

            if (hL > hR)
            {
                return 1 + hL;
            }
            else
            {
                return 1 + hR;
            }
        }
    }
}