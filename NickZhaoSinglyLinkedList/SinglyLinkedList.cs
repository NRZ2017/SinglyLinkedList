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
        bool IsEmpty;
        public SinglyLinkedList()
        {
        }

       public void AddLast(T value)
        {
            if(Head == null)
            {
                Head = new SinglyLinkedListNode<T>(value);
            }

            else
            {
                SinglyLinkedListNode<T> tempNode = Head;
                while(tempNode != null)
                {
                    if (tempNode.Next == null)
                    {
                        // Create a new item at 
                        tempNode.Next = new SinglyLinkedListNode<T>(value);
                        return;
                    }
                    tempNode = tempNode.Next;
                }
                
            }
        }
        public void AddFirst(T value)
        {  
            if (Head == null)
            {
                Head = new SinglyLinkedListNode<T>(value);
            }
            else
            {
                SinglyLinkedListNode<T> tempNode = new SinglyLinkedListNode<T>(value);
                tempNode.Next = Head;
                Head = tempNode;
            }
        }
        public bool Remove(T value)
        {

            if (Head == null)
            {
                return false;
            }
            else
            {
                SinglyLinkedListNode<T> tempNode = Head;
                while (tempNode != null)
                {
                    if (tempNode.Next.Data.CompareTo(value) == 0)
                    {
                        tempNode.Next = tempNode.Next.Next;
                        return true;
                    }

                    tempNode = tempNode.Next;
                }
                return false;
            }
        }

       public bool RemoveAt(int index)
        {
            if(IsEmpty)
            {
                return false;
            }

            else
            {
                SinglyLinkedListNode<T> tempnode = Head;
                for (int i = 0; i < index; i++)
                {
                    tempnode = tempnode.Next;
                }
                return false;
            }
        }

        void clear()
        {
            Head = null;
            count = 0;
            IsEmpty = true;
        }

        bool Contains(T value)
        {
            if(value == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        void Find(T value)
        {
            
        }
    }

}
