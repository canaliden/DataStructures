using DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            ILinkedList<int> list = new SingleLinkedList<int>();

            list.InsertFirst(new Node<int>(1));
            list.Print();
            
            Console.ReadKey();

        }
    }
}
