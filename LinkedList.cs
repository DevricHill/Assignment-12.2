using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_12._2
{
    public class Node 
    {
        public int Data;
        public Node Next;

        public Node(int data) 
        { 
            Data = data;
            Next = null;
        }
    }


    public class LinkedList
    {
        Node Head;
        Node Tail;
        int size;

        public Node GetHead() {  return Head; }

        public LinkedList()
        {
            Head = null;
            Tail = Head;
            size = 0;
        }

        private bool IsEmpty()
        {
            return size == 0;
        }

        public void Add(int data)
        {
            Node temp = new Node(data);

            if (IsEmpty())
            {
                Head = temp;
                Tail = temp;
            }
            else
            {
                Tail.Next = temp;
                Tail = temp;
            }
           
            size++;
        }

        public void Remove(int data)
        {
            while(Head != null && Head.Data == data)
            {
                Head = Head.Next;
            }


            if (Head == null) return;


            Node temp = Head;
            while (temp != null)
            {
                if(temp.Next.Data == data)
                {
                    temp.Next = temp.Next.Next;
                }

                temp = temp.Next;
            }

        }


    }
}
