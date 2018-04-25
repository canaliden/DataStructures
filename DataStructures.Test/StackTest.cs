

namespace DataStructures.Test
{
    #region Usings

    using System.Diagnostics;

    using DataStructures.LinkedList.Node;
    using DataStructures.Stack;
    using DataStructures.Stack;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void Count()
        {
            IStack<int> list = new Stack<int>();
            list.Push(1);
            list.Push(2);
            list.Push(3);
            Assert.AreEqual(list.Count(), 3);
        }

        [TestMethod]
        public void Clear()
        {
            IStack<int> list = new Stack<int>();
            list.Push(1);
            list.Push(2);
            list.Push(3);
            list.Clear();
            Assert.AreEqual(list.Count(), 0);
        }

        [TestMethod]
        public void Push()
        {
            IStack<int> list = new Stack<int>();
            list.Push(1);
            list.Push(2);
            list.Push(3);
            Assert.AreEqual(list.Peek(), 3);
            Assert.AreEqual(list.Pop(), 3);
            Assert.AreEqual(list.Peek(), 2);
        }

        [TestMethod]
        public void Pop()
        {
            IStack<int> list = new Stack<int>();
            list.Push(1);
            list.Push(2);
            list.Push(3);
            Assert.AreEqual(list.Pop(), 3);
            Assert.AreEqual(list.Pop(), 2);
            Assert.AreEqual(list.Pop(), 1);
            Assert.AreEqual(list.Count(), 0);
        }

        [TestMethod]
        public void Peek()
        {
            IStack<int> list = new Stack<int>();
            list.Push(1);
            list.Push(2);
            list.Push(3);
            Assert.AreEqual(list.Pop(), 3);
            Assert.AreEqual(list.Pop(), 2);
            Assert.AreEqual(list.Count(), 1);
            Assert.AreEqual(list.Pop(), 1);
            Assert.AreEqual(list.Count(), 0);
        }


        [TestMethod]
        public void BatchTest()
        {
            IStack<int> list = new Stack<int>();
            for (int i = 0; i < 10; i++)
            {
                if (i > 0)
                {
                    Debug.Write("-");
                }

                list.Push(i);
                Debug.Write(i);
            }
            Debug.WriteLine("");
            Debug.WriteLine("Stack Finished");
            Debug.WriteLine("-------------");
            for (int i = 1; i < 10; i += 5)
            {
                if (i > 1)
                {
                    Debug.Write("-");
                }

                var ii = list.Pop();
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
            for (int i = 1; i < 30; i += 2)
            {
                if (i > 1)
                {
                    Debug.Write("-");
                }

                var ii = list.Pop();
                Debug.Write(ii);
            }
            Debug.WriteLine("");
            Debug.WriteLine("Dequeue2 Finished");
            Debug.WriteLine("-------------");

            Assert.IsTrue(true);
        }
    }
}
 
