using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{

    public class SingleLinkedList<T> : ILinkedList<T>
    {
        private Node<T> start;

        private void CheckNull(Node<T> node)
        {
            if (node == null)
            {
                throw new Exception("Node cannot be null");
            }
        }

        public bool IsEmpty()
        {
            return start == null;
        }

        public int Count()
        {
            if (this.IsEmpty())
                return 0;

            int index = 1;
            Node<T> currentNode = start;
            while (currentNode.NextNode != null)
            {
                index++;
                currentNode = currentNode.NextNode;
            }

            return index;
        }

        public void Delete(T value)
        {
            // find and delete
            this.Find(new Node<T>(value), (t) =>
           {
               if (t.prevNode == null)
               {
                   start = t.node.NextNode;
               }
               else
               {
                   t.prevNode.NextNode = t.node.NextNode;
               }
           });
        }

        public void DeleteAt(int index)
        {
            // find and delete at index
            this.FindAtIndex(index, (t) =>
            {
                if (t.prevNode == null)
                {
                    start = t.node.NextNode;
                }
                else
                {
                    t.prevNode.NextNode = t.node.NextNode;
                }
            });
        }

        public void DeleteFirstNode()
        {
            if (start != null)
            {
                start = start.NextNode;
            }
        }

        public void DeleteLastNode()
        {
            this.FindLastNode(t =>
            {
                if (t.prevNode == null)
                {
                    start = null;
                }
                else
                {
                    t.prevNode.NextNode = null;
                }
            });
        }

        private Node<T> FindAtIndex(int index, Action<(Node<T> node, Node<T> prevNode, int index)> actionToExecute)
        {
            Node<T> prevNode = null;
            var currentNode = start;
            int currentIndex = 0;
            while (currentNode != null)
            {
                if (currentIndex == index)
                {
                    actionToExecute?.Invoke((currentNode, prevNode, currentIndex));
                    return currentNode;
                }

                prevNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            return null;
        }


        private Node<T> Find(Node<T> nodeToFind, Action<(Node<T> node, Node<T> prevNode, int index)> actionToExecute)
        {
            Node<T> prevNode = null;
            var currentNode = start;
            int currentIndex = 0;
            while (currentNode != null)
            {
                if (currentNode.Equals(nodeToFind))
                {
                    actionToExecute?.Invoke((currentNode, prevNode, currentIndex));
                    return currentNode;
                }

                prevNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            return null;
        }

        private Node<T> FindLastNode(Action<(Node<T> node, Node<T> prevNode, int index)> actionToExecute)
        {
            Node<T> prevNode = null;
            var currentNode = start;
            int currentIndex = 0;
            while (currentNode?.NextNode != null)
            {
                prevNode = currentNode;
                currentNode = currentNode.NextNode;
                currentIndex++;
            }

            if (currentNode != null)
                actionToExecute?.Invoke((currentNode, prevNode, currentIndex));

            return currentNode;
        }


        public Node<T> FindAtIndex(int index)
        {
            var nodeAtIndex = this.FindAtIndex(index, null);
            return nodeAtIndex;
        }
        public Node<T> Find(T value)
        {
            var matchedNode = this.Find(new Node<T>(value), null);
            return matchedNode;
        }
        public Node<T> FindLastNode()
        {
            var lastNode = this.FindLastNode(null);
            return lastNode;
        }

        public Node<T> FindFirstNode()
        {
            return start;
        }


        public bool HasCycle()
        {
            throw new NotImplementedException();
        }


        public void InsertAfter(T value, Node<T> newNode)
        {
            this.InsertAfter(new Node<T>(value), newNode);
        }
        public void InsertAfter(Node<T> value, Node<T> newNode)
        {
            // check for null
            this.CheckNull(newNode);

            // Find and execute action
            this.Find(value, (t) =>
           {
               newNode.NextNode = t.node.NextNode;
               t.node.NextNode = newNode;
           });
        }

        public void InsertAt(int index, Node<T> newNode)
        {
            // check for null
            this.CheckNull(newNode);

            // find at index and execute the action
            var node = this.FindAtIndex(index, (t) =>
            {
                if (t.prevNode == null)
                {
                    newNode.NextNode = t.node;
                    start = newNode;
                }
                else
                {
                    newNode.NextNode = t.prevNode.NextNode;
                    t.prevNode.NextNode = newNode;
                }
            });

            if (node == null)
            {
                start = newNode;
            }
        }


        public void InsertBefore(T value, Node<T> newNode)
        {
            this.InsertBefore(new Node<T>(value), newNode);
        }

        public void InsertBefore(Node<T> node, Node<T> newNode)
        {
            // check for null
            this.CheckNull(newNode);

            // find the value and execute the action
            this.Find(node, (t) =>
          {
              if (t.prevNode == null)
              {
                  newNode.NextNode = t.node;
                  start = newNode;
              }
              else
              {
                  newNode.NextNode = t.prevNode.NextNode;
                  t.prevNode.NextNode = newNode;
              }
          });
        }

        public void InsertFirst(Node<T> newNode)
        {
            // check for null
            this.CheckNull(newNode);

            // insert at first place
            this.InsertAt(0, newNode);
        }

        public void InsertLast(Node<T> newNode)
        {
            // check for null
            this.CheckNull(newNode);

            // find the last node and execute the action
            var node = this.FindLastNode((t) =>
            {
                t.node.NextNode = newNode;
            });

            if (node == null)
            {
                start = newNode;
            }
        }

        public void Print()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("List is empty");
                return;
            }

            Console.WriteLine("List contains: ");

            var currentNode = start;
            while (currentNode != null)
            {
                Console.Write(currentNode.Value);
                currentNode = currentNode.NextNode;
            }

            Console.WriteLine(string.Empty);
        }

        public void RemoveCycle()
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }

    }
}
