using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Test
{
    using System.Diagnostics;

    using DataStructures.BinaryTree;

    [TestClass]
    public class BinarySearchTreeTest
    {
        private BinarySearchTree BuildTree()
        {
            var search = new BinarySearchTree();
            search.Insert(70);
            search.Insert(55);
            search.Insert(21);
            search.Insert(599);
            search.Insert(59);
            search.Insert(409);
            search.Insert(15);
            search.Insert(58);
            search.Insert(49);
            search.Insert(4);
            search.Insert(29);
            search.Insert(411);
            search.Insert(22);
            return search;
        }

        [TestMethod]
        public void Insert()
        {
            var search = this.BuildTree();
            search.Insert(1);
            var found = search.Search(1);
            Assert.AreEqual(1, found.Value);
        }

        [TestMethod]
        public void Delete()
        {
            var search = this.BuildTree();
            search.Delete(15);
            var found = search.Search(15);
            Assert.AreEqual(null, found);
        }

        [TestMethod]
        public void GetHeight()
        {
            var search = this.BuildTree();
            var height= search.GetHeight();
            Assert.AreEqual(6, height);
        }
    }
}
