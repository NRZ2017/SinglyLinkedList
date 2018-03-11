using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickZhaoSinglyLinkedList
{
    class Program
    {


        static void Main(string[] args)
        {
            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();
            singlyLinkedList.AddFirst(1);
            
            singlyLinkedList.AddLast(2);

            //    singlyLinkedList.AddLast(3);

            //     singlyLinkedList.AddFirst(0);

            //  singlyLinkedList.AddFirst(555);

            // singlyLinkedList.Remove(0);

            // singlyLinkedList.RemoveAt(2);

            singlyLinkedList.Find(singlyLinkedList.num);

            singlyLinkedList.Contains(34);

          //  singlyLinkedList.clear();
        }
    }
}
