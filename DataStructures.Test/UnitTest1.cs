using System;
using DataStructures.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Test
{

    [TestClass]
    public class SingleLinkedListTest
    {
        [TestMethod]
        public void Count()
        {
            ILinkedList<int> list = new SingleLinkedList<int>();
            list.InsertAt(0, new Node<int>(1));
            list.InsertAt(0, new Node<int>(1));
            list.InsertAt(0, new Node<int>(1));
            list.DeleteAt(0);
            list.InsertAt(0, new Node<int>(1));

            Assert.AreEqual(list.Count(), 3);
        }

        [TestMethod]
        public void IsEmpty()
        {
            ILinkedList<int> list = new SingleLinkedList<int>();
            list.InsertAt(0, new Node<int>(1));
            list.InsertAt(0, new Node<int>(1));
            list.InsertAt(0, new Node<int>(1));
            list.InsertAt(0, new Node<int>(1));
            list.DeleteAt(0);
            list.DeleteAt(0);
            list.DeleteAt(0);
            list.DeleteAt(0);

            Assert.AreEqual(list.IsEmpty(), true);
        }


        [TestMethod]
        public void InsertAfter()
        {
            ILinkedList<int> list = new SingleLinkedList<int>();
            list.InsertFirst(new Node<int>(22));
            list.InsertAfter(22, new Node<int>(1));
            Assert.AreEqual(list.FindLastNode().Value, 1);
        }


        [TestMethod]
        public void InsertAt()
        {
            ILinkedList<int> list = new SingleLinkedList<int>();
            list.InsertAt(0, new Node<int>(1));
            list.InsertAt(0, new Node<int>(122));
            Assert.AreEqual(list.FindAtIndex(0).Value, 122);
        }


        [TestMethod]
        public void InsertBefore()
        {
            ILinkedList<int> list = new SingleLinkedList<int>();
            list.InsertAt(0, new Node<int>(1));
            list.InsertBefore(1, new Node<int>(122));
            Assert.AreEqual(list.FindAtIndex(0).Value, 122);
        }

        [TestMethod]
        public void InsertFirst()
        {
            ILinkedList<int> list = new SingleLinkedList<int>();
            list.InsertLast(new Node<int>(1));
            Assert.AreEqual(list.FindFirstNode()?.Value, 1);
        }

        [TestMethod]
        public void InsertLast()
        {
            ILinkedList<int> list = new SingleLinkedList<int>();
            list.InsertLast(new Node<int>(221));
            Assert.AreEqual(list.FindLastNode()?.Value, 221);
        }


        [TestMethod]
        public void DeleteAt()
        {
            ILinkedList<int> list = new SingleLinkedList<int>();
            list.InsertAt(0, new Node<int>(1));
            list.InsertAt(0, new Node<int>(12));
            list.InsertAt(0, new Node<int>(13));
            list.InsertAt(0, new Node<int>(14));
            list.DeleteAt(0);

            Assert.AreEqual(list.FindFirstNode()?.Value, 13);
        }

        [TestMethod]
        public void Delete()
        {
            ILinkedList<int> list = new SingleLinkedList<int>();
            list.InsertAt(0, new Node<int>(1));
            list.InsertAt(0, new Node<int>(12));
            list.InsertAt(0, new Node<int>(13));
            list.InsertAt(0, new Node<int>(14));
            list.Delete(1);

            Assert.AreEqual(list.FindLastNode()?.Value, 12);
        }

        [TestMethod]
        public void DeleteFirstNode()
        {
            ILinkedList<int> list = new SingleLinkedList<int>();
            list.InsertAt(0, new Node<int>(1));
            list.InsertAt(0, new Node<int>(12));
            list.InsertAt(0, new Node<int>(13));
            list.InsertAt(0, new Node<int>(14));
            list.DeleteFirstNode();

            Assert.AreEqual(list.FindFirstNode()?.Value, 13);
        }


        [TestMethod]
        public void DeleteLastNode()
        {
            ILinkedList<int> list = new SingleLinkedList<int>();
            list.InsertAt(0, new Node<int>(1));
            list.InsertAt(0, new Node<int>(12));
            list.InsertAt(0, new Node<int>(13));
            list.InsertAt(0, new Node<int>(14));
            list.DeleteLastNode();

            Assert.AreEqual(list.FindLastNode()?.Value, 12);
        }



        [TestMethod]
        public void Find()
        {
            ILinkedList<int> list = new SingleLinkedList<int>();
            list.InsertAt(0, new Node<int>(1));
            list.InsertAt(0, new Node<int>(12));
            list.InsertAt(0, new Node<int>(13));
            list.InsertAt(0, new Node<int>(14));

            Assert.AreEqual(list.Find(12)?.Value, 12);
        }

        [TestMethod]
        public void FindFirstNode()
        {
            ILinkedList<int> list = new SingleLinkedList<int>();
            list.InsertAt(0, new Node<int>(1));
            list.InsertAt(0, new Node<int>(12));
            list.InsertAt(0, new Node<int>(13));
            list.InsertAt(0, new Node<int>(14));

            Assert.AreEqual(list.FindFirstNode()?.Value, 14);
        }


        [TestMethod]
        public void FindAtIndex()
        {
            ILinkedList<int> list = new SingleLinkedList<int>();
            list.InsertAt(0, new Node<int>(1));
            list.InsertAt(0, new Node<int>(12));
            list.InsertAt(0, new Node<int>(13));
            list.InsertAt(0, new Node<int>(14));

            Assert.AreEqual(list.FindAtIndex(2)?.Value, 12);
        }


        [TestMethod]
        public void FindLastNode()
        {
            ILinkedList<int> list = new SingleLinkedList<int>();
            list.InsertAt(0, new Node<int>(1));
            list.InsertAt(0, new Node<int>(12));
            list.InsertAt(0, new Node<int>(13));
            list.InsertAt(0, new Node<int>(14));

            Assert.AreEqual(list.FindLastNode()?.Value, 1);
        }



    }
}

