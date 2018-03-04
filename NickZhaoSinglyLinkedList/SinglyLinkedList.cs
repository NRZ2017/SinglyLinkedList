using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickZhaoSinglyLinkedList
{
    class SinglyLinkedList<T> where T : IComparable<T>
    {
        public SinglyLinkedListNode<T> Head;
        int count = 0;
        T nodetoinsert;
        public SinglyLinkedListNode<T> tempNode;
        T TempValue;
        public SinglyLinkedList(T NodeToInsert)
        {
            NodeToInsert = nodetoinsert;
        }

        void AddLast(T value)
        {
            if(Head == null)
            {
                nodetoinsert = Head.Data;
            }

            else
            {
                while(tempNode.Data != null)
                {
                    tempNode = tempNode.Next;
                }
                
            }
        }
        void AddFirst(T value)
        {
            if(Head == null)
            {
                nodetoinsert = Head.Data;
            }
            else
            {
                TempValue = Head.Data;
                Head.Data = nodetoinsert;
                Head = Head.Next;
            }
        }
        bool Remove(T value)
        {
            if (Head == null)
            {
                return false;
            }
            else
            {

            }
        }
    }
}
