using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace Node_Tiyul
{
    class NodeManager
    {
        public static Node<int> CreateNewNodeList(int count=12)
        {
            Random rnd = new Random();
            Node<int> first = new Node<int>(rnd.Next(100) + 1);
            Node<int> cont = first;
            for (int i = 1; i < count; i++)
            { 
                cont.SetNext(new Node<int>(rnd.Next(100) + 1));
                cont = cont.GetNext();
            }
            return first;
        }
        public static void Print (Node<int> first)
        {
            Console.Write(first.GetValue());
            first = first.GetNext();
            while (first!= null)
            {
                Console.Write(", {0}", first.GetValue());
                first = first.GetNext();
            }
        }
        
    }
}
