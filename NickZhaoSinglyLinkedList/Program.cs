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
            singlyLinkedList.AddFirst(5);
            
            singlyLinkedList.AddLast(22);

            singlyLinkedList.AddLast(44);

            singlyLinkedList.AddFirst(234);

            singlyLinkedList.AddFirst(555);

            singlyLinkedList.Remove(22);

            singlyLinkedList.RemoveAt(4);
        }
    }
}
