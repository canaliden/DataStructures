// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SingleLinkedListTest.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.Test
{
    #region Usings

    using DataStructures.LinkedList.Cycle;
    using DataStructures.LinkedList.Node;
    using DataStructures.LinkedList.SinglyLinked;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    /// <summary>
    ///     The single linked list test.
    /// </summary>
    [TestClass]
    public class SingleLinkedListTest
    {
        /// <summary>
        ///     The count.
        /// </summary>
        [TestMethod]
        public void Count()
        {
            ISinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddAt(0, new SinglyLinkedListNode<int>(1));
            list.AddAt(0, new SinglyLinkedListNode<int>(1));
            list.AddAt(0, new SinglyLinkedListNode<int>(1));
            list.RemoveAt(0);
            list.AddAt(0, new SinglyLinkedListNode<int>(1));

            Assert.AreEqual(list.Count(), 3);
        }

        /// <summary>
        ///     The delete.
        /// </summary>
        [TestMethod]
        public void Delete()
        {
            ISinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddAt(0, new SinglyLinkedListNode<int>(1));
            list.AddAt(0, new SinglyLinkedListNode<int>(12));
            list.AddAt(0, new SinglyLinkedListNode<int>(13));
            list.AddAt(0, new SinglyLinkedListNode<int>(14));
            list.Remove(1);

            Assert.AreEqual(list.FindLastNode()?.Value, 12);
        }

        /// <summary>
        ///     The delete at.
        /// </summary>
        [TestMethod]
        public void DeleteAt()
        {
            ISinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddAt(0, new SinglyLinkedListNode<int>(1));
            list.AddAt(0, new SinglyLinkedListNode<int>(12));
            list.AddAt(0, new SinglyLinkedListNode<int>(13));
            list.AddAt(0, new SinglyLinkedListNode<int>(14));
            list.RemoveAt(0);

            Assert.AreEqual(list.FindFirstNode()?.Value, 13);
        }

        /// <summary>
        ///     The delete first node.
        /// </summary>
        [TestMethod]
        public void DeleteFirstNode()
        {
            ISinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddAt(0, new SinglyLinkedListNode<int>(1));
            list.AddAt(0, new SinglyLinkedListNode<int>(12));
            list.AddAt(0, new SinglyLinkedListNode<int>(13));
            list.AddAt(0, new SinglyLinkedListNode<int>(14));
            list.RemoveFirstNode();

            Assert.AreEqual(list.FindFirstNode()?.Value, 13);
        }

        /// <summary>
        ///     The delete last node.
        /// </summary>
        [TestMethod]
        public void DeleteLastNode()
        {
            ISinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddAt(0, new SinglyLinkedListNode<int>(1));
            list.AddAt(0, new SinglyLinkedListNode<int>(12));
            list.AddAt(0, new SinglyLinkedListNode<int>(13));
            list.AddAt(0, new SinglyLinkedListNode<int>(14));
            list.RemoveLastNode();

            Assert.AreEqual(list.FindLastNode()?.Value, 12);
        }

        /// <summary>
        ///     The find.
        /// </summary>
        [TestMethod]
        public void Find()
        {
            ISinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddAt(0, new SinglyLinkedListNode<int>(1));
            list.AddAt(0, new SinglyLinkedListNode<int>(12));
            list.AddAt(0, new SinglyLinkedListNode<int>(13));
            list.AddAt(0, new SinglyLinkedListNode<int>(14));

            Assert.AreEqual(list.Find(12)?.Value, 12);
        }

        /// <summary>
        ///     The find at ındex.
        /// </summary>
        [TestMethod]
        public void FindAtIndex()
        {
            ISinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddAt(0, new SinglyLinkedListNode<int>(1));
            list.AddAt(0, new SinglyLinkedListNode<int>(12));
            list.AddAt(0, new SinglyLinkedListNode<int>(13));
            list.AddAt(0, new SinglyLinkedListNode<int>(14));

            Assert.AreEqual(list.FindAtIndex(2)?.Value, 12);
        }

        /// <summary>
        ///     The find first node.
        /// </summary>
        [TestMethod]
        public void FindFirstNode()
        {
            ISinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddAt(0, new SinglyLinkedListNode<int>(1));
            list.AddAt(0, new SinglyLinkedListNode<int>(12));
            list.AddAt(0, new SinglyLinkedListNode<int>(13));
            list.AddAt(0, new SinglyLinkedListNode<int>(14));

            Assert.AreEqual(list.FindFirstNode()?.Value, 14);
        }

        /// <summary>
        ///     The find last node.
        /// </summary>
        [TestMethod]
        public void FindLastNode()
        {
            ISinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddAt(0, new SinglyLinkedListNode<int>(1));
            list.AddAt(0, new SinglyLinkedListNode<int>(12));
            list.AddAt(0, new SinglyLinkedListNode<int>(13));
            list.AddAt(0, new SinglyLinkedListNode<int>(14));

            Assert.AreEqual(list.FindLastNode()?.Value, 1);
        }

        /// <summary>
        ///     The has cycle.
        /// </summary>
        [TestMethod]
        public void HasCycle()
        {
            ISinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddLast(new SinglyLinkedListNode<int>(1));
            list.AddLast(new SinglyLinkedListNode<int>(2));
            list.AddLast(new SinglyLinkedListNode<int>(3));
            list.AddLast(new SinglyLinkedListNode<int>(4));
            list.AddLast(new SinglyLinkedListNode<int>(5));
            list.AddLast(new SinglyLinkedListNode<int>(6));
            list.AddLast(new SinglyLinkedListNode<int>(7));
            list.AddLast(new SinglyLinkedListNode<int>(8));
            list.AddLast(new SinglyLinkedListNode<int>(9));
            list.AddLast(new SinglyLinkedListNode<int>(10));

            // var middle = list.Find(5);
            // var lastNode = list.FindLastNode();
            // lastNode.NextNode = middle;
            var cycleHandler = new FloydsCycleDetection<int>();

            Assert.AreEqual(cycleHandler.HasCycle(list), false);
        }

        /// <summary>
        ///     The ınsert after.
        /// </summary>
        [TestMethod]
        public void InsertAfter()
        {
            ISinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddFirst(new SinglyLinkedListNode<int>(22));
            list.AddAfter(22, new SinglyLinkedListNode<int>(1));
            Assert.AreEqual(list.FindLastNode().Value, 1);
        }

        /// <summary>
        ///     The ınsert at.
        /// </summary>
        [TestMethod]
        public void InsertAt()
        {
            ISinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddAt(0, new SinglyLinkedListNode<int>(1));
            list.AddAt(0, new SinglyLinkedListNode<int>(122));
            Assert.AreEqual(list.FindAtIndex(0).Value, 122);
        }

        /// <summary>
        ///     The ınsert before.
        /// </summary>
        [TestMethod]
        public void InsertBefore()
        {
            ISinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddAt(0, new SinglyLinkedListNode<int>(1));
            list.AddBefore(1, new SinglyLinkedListNode<int>(122));
            Assert.AreEqual(list.FindAtIndex(0).Value, 122);
        }

        /// <summary>
        ///     The ınsert first.
        /// </summary>
        [TestMethod]
        public void InsertFirst()
        {
            ISinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddLast(new SinglyLinkedListNode<int>(1));
            Assert.AreEqual(list.FindFirstNode()?.Value, 1);
        }

        /// <summary>
        ///     The ınsert last.
        /// </summary>
        [TestMethod]
        public void InsertLast()
        {
            ISinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddLast(new SinglyLinkedListNode<int>(221));
            Assert.AreEqual(list.FindLastNode()?.Value, 221);
        }

        /// <summary>
        ///     The ıs empty.
        /// </summary>
        [TestMethod]
        public void IsEmpty()
        {
            ISinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddAt(0, new SinglyLinkedListNode<int>(1));
            list.AddAt(0, new SinglyLinkedListNode<int>(1));
            list.AddAt(0, new SinglyLinkedListNode<int>(1));
            list.AddAt(0, new SinglyLinkedListNode<int>(1));
            list.RemoveAt(0);
            list.RemoveAt(0);
            list.RemoveAt(0);
            list.RemoveAt(0);

            Assert.AreEqual(list.IsEmpty(), true);
        }

        /// <summary>
        ///     The remove cycle.
        /// </summary>
        [TestMethod]
        public void RemoveCycle()
        {
            ISinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddLast(new SinglyLinkedListNode<int>(1));
            list.AddLast(new SinglyLinkedListNode<int>(2));
            list.AddLast(new SinglyLinkedListNode<int>(3));
            list.AddLast(new SinglyLinkedListNode<int>(4));
            list.AddLast(new SinglyLinkedListNode<int>(5));
            list.AddLast(new SinglyLinkedListNode<int>(6));
            list.AddLast(new SinglyLinkedListNode<int>(7));
            list.AddLast(new SinglyLinkedListNode<int>(8));
            list.AddLast(new SinglyLinkedListNode<int>(9));
            list.AddLast(new SinglyLinkedListNode<int>(10));

            // var middle = list.Find(5);
            // var lastNode = list.FindLastNode();
            // lastNode.NextNode = middle;
            var cycleHandler = new FloydsCycleDetection<int>();
            cycleHandler.RemoveCycle(list);

            Assert.AreEqual(cycleHandler.HasCycle(list), false);
        }

        /// <summary>
        ///     The reverse.
        /// </summary>
        [TestMethod]
        public void Reverse()
        {
            ISinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddLast(new SinglyLinkedListNode<int>(1));
            list.AddLast(new SinglyLinkedListNode<int>(2));
            list.AddLast(new SinglyLinkedListNode<int>(3));
            list.AddLast(new SinglyLinkedListNode<int>(4));
            list.AddLast(new SinglyLinkedListNode<int>(5));
            list.AddLast(new SinglyLinkedListNode<int>(6));
            list.AddLast(new SinglyLinkedListNode<int>(7));
            list.AddLast(new SinglyLinkedListNode<int>(8));
            list.AddLast(new SinglyLinkedListNode<int>(9));
            list.AddLast(new SinglyLinkedListNode<int>(10));

            list.Reverse();

            Assert.AreEqual(list.FindFirstNode().Value, 10);
        }
    }
}