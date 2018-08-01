using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    class LinkedList
    {
        Node head;

        
        internal class Node
        {
            int data;
            internal Node next;
           internal Node(int d) { data = d; next = null; } // Constructor
        }
        
        public static void main(String[] args)
        {
            /* Start with the empty list. */
            LinkedList llist = new LinkedList();

            llist.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);           

            llist.head.next = second; // Link first node with the second node           
            second.next = third; // Link second node with the third node
           
        }
    }


}
