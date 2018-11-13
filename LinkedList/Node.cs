using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {

        public int value { get; set; }

        public Node Next { get; set; }


        public Node(int NodeValue)
        {
            value = NodeValue;
            Next = null;
        }
    }

    class LinkedList
    {
        public Node head { get; set; }

        public Node tail { get; set; }


        public LinkedList()
        {
            head = null;
            tail = null;
        }


        public Node InsertNode(int vale)
        {
            Node newNode = new Node(vale);
            return newNode;
        }


        public LinkedList CreateList()
        {
            LinkedList list = new LinkedList();
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {

                var newNode = InsertNode(Convert.ToInt32(Console.ReadLine()));

                if (list.head == null)
                    list.head = newNode;
                else
                    list.tail.Next = newNode;


                list.tail = newNode;
            }
            return list;

        }


        public LinkedList AddItemToTop(LinkedList lst, int value)
        {
            Node temp = lst.head;

            lst.head = new Node(value);

            lst.head.Next = temp;

            if (lst.tail == null) lst.tail = lst.head;

            return  lst;
        }


        public LinkedList AddItemToBottom(LinkedList lst, int value)
        {
            lst.tail.Next = new Node(value);

            lst.tail = new Node(value);

            return lst;
        }

    }


   
}
