// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DoublyLinkedListTest.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.Test
{
    #region Usings

    using DataStructures.LinkedList;
    using DataStructures.LinkedList.DoublyLinked;
    using DataStructures.LinkedList.Node;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    ///     The doubly linked list test.
    /// </summary>
    [TestClass]
    public class DoublyLinkedListTest
    {
        /// <summary>
        ///     The count.
        /// </summary>
        [TestMethod]
        public void Count()
        {
            IDoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddAt(0, new DoublyLinkedListNode<int>(1));
            list.AddAt(0, new DoublyLinkedListNode<int>(2));
            list.AddAt(0, new DoublyLinkedListNode<int>(3));
            list.RemoveAt(0);
            list.AddAt(0, new DoublyLinkedListNode<int>(4));

            Assert.AreEqual(list.Count(), 3);
        }

        /// <summary>
        ///     The delete.
        /// </summary>
        [TestMethod]
        public void Delete()
        {
            IDoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddAt(0, new DoublyLinkedListNode<int>(1));
            list.AddAt(0, new DoublyLinkedListNode<int>(12));
            list.AddAt(0, new DoublyLinkedListNode<int>(13));
            list.AddAt(0, new DoublyLinkedListNode<int>(14));
            list.Remove(1);

            Assert.AreEqual(list.FindLastNode()?.Value, 12);
        }

        /// <summary>
        ///     The delete at.
        /// </summary>
        [TestMethod]
        public void DeleteAt()
        {
            IDoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddAt(0, new DoublyLinkedListNode<int>(1));
            list.AddAt(0, new DoublyLinkedListNode<int>(12));
            list.AddAt(0, new DoublyLinkedListNode<int>(13));
            list.AddAt(0, new DoublyLinkedListNode<int>(14));
            list.RemoveAt(0);

            Assert.AreEqual(list.FindFirstNode()?.Value, 13);
        }

        /// <summary>
        ///     The delete first node.
        /// </summary>
        [TestMethod]
        public void DeleteFirstNode()
        {
            IDoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddAt(0, new DoublyLinkedListNode<int>(1));
            list.AddAt(0, new DoublyLinkedListNode<int>(12));
            list.AddAt(0, new DoublyLinkedListNode<int>(13));
            list.AddAt(0, new DoublyLinkedListNode<int>(14));
            list.RemoveFirstNode();

            Assert.AreEqual(list.FindFirstNode()?.Value, 13);
        }

        /// <summary>
        ///     The delete last node.
        /// </summary>
        [TestMethod]
        public void DeleteLastNode()
        {
            IDoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddAt(0, new DoublyLinkedListNode<int>(1));
            list.AddAt(0, new DoublyLinkedListNode<int>(12));
            list.AddAt(0, new DoublyLinkedListNode<int>(13));
            list.AddAt(0, new DoublyLinkedListNode<int>(14));
            list.RemoveLastNode();

            Assert.AreEqual(list.FindLastNode()?.Value, 12);
        }

        /// <summary>
        ///     The find.
        /// </summary>
        [TestMethod]
        public void Find()
        {
            IDoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddAt(0, new DoublyLinkedListNode<int>(1));
            list.AddAt(0, new DoublyLinkedListNode<int>(12));
            list.AddAt(0, new DoublyLinkedListNode<int>(13));
            list.AddAt(0, new DoublyLinkedListNode<int>(14));

            Assert.AreEqual(list.Find(12)?.Value, 12);
        }

        /// <summary>
        ///     The find at ındex.
        /// </summary>
        [TestMethod]
        public void FindAtIndex()
        {
            IDoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddAt(0, new DoublyLinkedListNode<int>(1));
            list.AddAt(0, new DoublyLinkedListNode<int>(12));
            list.AddAt(0, new DoublyLinkedListNode<int>(13));
            list.AddAt(0, new DoublyLinkedListNode<int>(14));

            Assert.AreEqual(list.FindAtIndex(2)?.Value, 12);
        }

        /// <summary>
        ///     The find first node.
        /// </summary>
        [TestMethod]
        public void FindFirstNode()
        {
            IDoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddAt(0, new DoublyLinkedListNode<int>(1));
            list.AddAt(0, new DoublyLinkedListNode<int>(12));
            list.AddAt(0, new DoublyLinkedListNode<int>(13));
            list.AddAt(0, new DoublyLinkedListNode<int>(14));

            Assert.AreEqual(list.FindFirstNode()?.Value, 14);
        }

        /// <summary>
        ///     The find last node.
        /// </summary>
        [TestMethod]
        public void FindLastNode()
        {
            IDoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddAt(0, new DoublyLinkedListNode<int>(1));
            list.AddAt(0, new DoublyLinkedListNode<int>(12));
            list.AddAt(0, new DoublyLinkedListNode<int>(13));
            list.AddAt(0, new DoublyLinkedListNode<int>(14));

            Assert.AreEqual(list.FindLastNode()?.Value, 1);
        }

        /// <summary>
        ///     The ınsert after.
        /// </summary>
        [TestMethod]
        public void InsertAfter()
        {
            IDoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddFirst(new DoublyLinkedListNode<int>(22));
            list.AddAfter(22, new DoublyLinkedListNode<int>(1));
            Assert.AreEqual(list.FindLastNode().Value, 1);
        }

        /// <summary>
        ///     The ınsert at.
        /// </summary>
        [TestMethod]
        public void InsertAt()
        {
            IDoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddAt(0, new DoublyLinkedListNode<int>(1));
            list.AddAt(0, new DoublyLinkedListNode<int>(122));
            Assert.AreEqual(list.FindAtIndex(0).Value, 122);
        }

        /// <summary>
        ///     The ınsert before.
        /// </summary>
        [TestMethod]
        public void InsertBefore()
        {
            IDoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddAt(0, new DoublyLinkedListNode<int>(1));
            list.AddBefore(1, new DoublyLinkedListNode<int>(122));
            Assert.AreEqual(list.FindAtIndex(0).Value, 122);
        }

        /// <summary>
        ///     The ınsert first.
        /// </summary>
        [TestMethod]
        public void InsertFirst()
        {
            IDoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddLast(new DoublyLinkedListNode<int>(1));
            Assert.AreEqual(list.FindFirstNode()?.Value, 1);
        }

        /// <summary>
        ///     The ınsert last.
        /// </summary>
        [TestMethod]
        public void InsertLast()
        {
            IDoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddLast(new DoublyLinkedListNode<int>(221));
            Assert.AreEqual(list.FindLastNode()?.Value, 221);
        }

        /// <summary>
        ///     The ıs empty.
        /// </summary>
        [TestMethod]
        public void IsEmpty()
        {
            IDoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddAt(0, new DoublyLinkedListNode<int>(1));
            list.AddAt(0, new DoublyLinkedListNode<int>(1));
            list.AddAt(0, new DoublyLinkedListNode<int>(1));
            list.AddAt(0, new DoublyLinkedListNode<int>(1));
            list.RemoveAt(0);
            list.RemoveAt(0);
            list.RemoveAt(0);
            list.RemoveAt(0);

            Assert.AreEqual(list.IsEmpty(), true);
        }
    }
}