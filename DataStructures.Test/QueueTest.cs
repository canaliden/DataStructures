

namespace DataStructures.Test
{
    #region Usings

    using System.Diagnostics;

    using DataStructures.LinkedList.Node;
    using DataStructures.Queue;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void Count()
        {
            IQueue<int> list = new Queue<int>();
            list.Enqueue(1);
            list.Enqueue(2);
            list.Enqueue(3);
            Assert.AreEqual(list.Count(), 3);
        }

        [TestMethod]
        public void Clear()
        {
            IQueue<int> list = new Queue<int>();
            list.Enqueue(1);
            list.Enqueue(2);
            list.Enqueue(3);
            list.Clear();
            Assert.AreEqual(list.Count(), 0);
        }

        [TestMethod]
        public void Enqueue()
        {
            IQueue<int> list = new Queue<int>();
            list.Enqueue(1);
            list.Enqueue(2);
            list.Enqueue(3);
            Assert.AreEqual(list.Peek(), 1);
            Assert.AreEqual(list.Dequeue(), 1);
            Assert.AreEqual(list.Peek(), 2);
        }

        [TestMethod]
        public void Dequeue()
        {
            IQueue<int> list = new Queue<int>();
            list.Enqueue(1);
            list.Enqueue(2);
            list.Enqueue(3);
            Assert.AreEqual(list.Dequeue(), 1);
            Assert.AreEqual(list.Dequeue(), 2);
            Assert.AreEqual(list.Dequeue(), 3);
            Assert.AreEqual(list.Count(), 0);
        }

        [TestMethod]
        public void Peek()
        {
            IQueue<int> list = new Queue<int>();
            list.Enqueue(1);
            list.Enqueue(2);
            list.Enqueue(3);
            Assert.AreEqual(list.Peek(), 1);
            Assert.AreEqual(list.Peek(), 1);
            Assert.AreEqual(list.Dequeue(), 1);
            Assert.AreEqual(list.Dequeue(), 2);
            Assert.AreEqual(list.Count(), 1);
        }

        [TestMethod]
        public void BatchTest()
        {
            IQueue<int> list = new Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                if (i>0)
                {
                    Debug.Write("-");
                }

                list.Enqueue(i);
                Debug.Write(i);
            }
            Debug.WriteLine("");
            Debug.WriteLine("Queue Finished");
            Debug.WriteLine("-------------");
            for (int i = 1; i < 10; i += 5)
            {
                if (i > 1)
                {
                    Debug.Write("-");
                }

                var ii = list.Dequeue();
                Debug.Write(ii);
            }

            Debug.WriteLine("");
            Debug.WriteLine("Dequeue Finished");
            Debug.WriteLine("-------------");
            Debug.WriteLine("");

            for (int i = 1; i < 10; i += 2)
            {
                if (i > 1)
                {
                    Debug.Write("-");
                }

                var ii = list.Peek();
                Debug.Write(ii);
            }

            Debug.WriteLine("");
            Debug.WriteLine("Peek Finished");
            Debug.WriteLine("-------------");
            Debug.WriteLine("");
            for (int i = 1; i < 10; i += 2)
            {
                if (i > 1)
                {
                    Debug.Write("-");
                }

                var ii = list.Dequeue();
                Debug.Write(ii);
            }
            Debug.WriteLine("");
            Debug.WriteLine("Dequeue2 Finished");
            Debug.WriteLine("-------------");

            Assert.IsTrue(true);
        }

    }
}

