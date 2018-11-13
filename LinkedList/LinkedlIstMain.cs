using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedlIstMain
    {

        static void Main(string[] args)
        {
            LinkedList lst = new LinkedList();

            //method to create list Add 1,2,3,4,5

             var mylist= lst.CreateList();


            //method to insert an element at top
           mylist= lst.AddItemToTop(mylist, 0);


            //method to insert an element at botton
            mylist = lst.AddItemToBottom(mylist, 10);




        }
    }
}
