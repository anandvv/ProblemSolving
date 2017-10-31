using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignQuestions
{
    class NthLastNodeOfLinkedList
    {
        LinkedList<int> list;

        public NthLastNodeOfLinkedList()
        {
            list = new LinkedList<int>();
        }

        public void setupTestData(int[] array)
        {
            foreach(var item in array)
            {
                this.list.AddLast(item);
            }
        }
        public int getNthLastNode(int n)
        {
            int i = 0;
            LinkedListNode<int> head, follow;
            head = list.First;

            while(i < n && head.Next!= null)
            {
                head = head.Next;
                i++;
            }

            if(head == null)
            {
                Console.WriteLine("There aren't enough nodes in the list");
                return -1;
            }
            else
            {
                follow = list.First;
            }

            while(head != null)
            {
                head = head.Next;
                follow = follow.Next;
            }

            return follow.Value;
        }
    }
}
