using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Test
{
    using DataStructures.Heap;

    [TestClass]
    public class HeapTreeTest
    {
        [TestMethod]
        public void Insert()
        {
            var heapTree = new HeapTree();
            heapTree.Insert(55);
            int index =  heapTree.Search(55);
            Assert.AreEqual(1,index);
        }

        [TestMethod]
        public void Delete()
        {
            var heapTree = new HeapTree();
            heapTree.Insert(5);
            heapTree.Insert(6);
            heapTree.Insert(15);
            heapTree.Insert(7);
            heapTree.Insert(12);
            heapTree.Insert(9);
            heapTree.Insert(2);
            heapTree.Insert(54);
            heapTree.Insert(59);
            heapTree.Display();
            heapTree.DeleteRoot();
            heapTree.Display();
            int index = heapTree.Search(54);
            Assert.AreEqual(1, index);
        }
    }
}
