using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickZhaoSinglyLinkedList
{
    class SinglyLinkedListNode<T>
    {
        public T Data;
        public SinglyLinkedListNode<T> Next;

        public SinglyLinkedListNode(T data)
        {
            Data = data;
        }
            
    }
}
