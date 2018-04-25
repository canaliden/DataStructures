

namespace DataStructures.Test
{
    #region Usings

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
            Assert.AreEqual(list.Peek(), 3);
            Assert.AreEqual(list.Dequeue(), 3);
            Assert.AreEqual(list.Peek(), 2);
        }

        [TestMethod]
        public void Dequeue()
        {
            IQueue<int> list = new Queue<int>();
            list.Enqueue(1);
            list.Enqueue(2);
            list.Enqueue(3);
            Assert.AreEqual(list.Dequeue(), 3);
            Assert.AreEqual(list.Dequeue(), 2);
            Assert.AreEqual(list.Dequeue(), 1);
            Assert.AreEqual(list.Count(), 0);
        }
    }
}
 
