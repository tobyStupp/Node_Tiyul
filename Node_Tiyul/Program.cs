using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace Node_Tiyul
{
    class Program
    {
        public static int Count (Node<int> p)
        {
            // Gets the beginning of a Linked List and returns how many  Nodes there are
            throw new NotImplementedException();
        }
        public static int SumEven (Node<int> p)
        {
            // calculates sum of all even variables that are even in the nulls
            throw new NotImplementedException();
        }
        public static int GetBiggest (Node<int> p)
        {
            //gets the value of the largest node in the list
            throw new NotImplementedException();
        }
        public static bool IsSorted (Node<int> p)
        {
            // returns true if the Linked list starting at p is sorted?
            throw new NotImplementedException();
        }
        public static bool Exists (Node<int> p , int x)
        {
            //Gets the beginning of a linked list and returns true if you found X int the list and false if not
            throw new NotImplementedException();
        }
        static void Main(string[] args)
        {
            Node<int> p = NodeManager.CreateNewNodeList();
            NodeManager.Print(p);
            Console.WriteLine($"there are {Count(p)}");
           Console.WriteLine ($"The biggest is {GetBiggest(p)}");


            Console.WriteLine("input number to find");
            int x = int.Parse(Console.ReadLine());
            // check if lis sorted
            if (Exists(p, x))
                Console.WriteLine("FOUND");
            else
                Console.WriteLine("NOT FOUND);
      



        }
    }
}
