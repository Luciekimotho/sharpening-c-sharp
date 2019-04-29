using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{

    class LinkedNode
    {
        public char data;
        public LinkedNode next;
        public static int count = 0;

        public LinkedNode(char val)
        {
            data = val;
            next = null;
            count++;
        }
    }

    class LinkedList
    {
        public LinkedNode head;
       
        public LinkedList()
        {
            head = null;
        }

        public void printList(LinkedNode curr)
        {
            if(curr == null)
            {
                Console.WriteLine("\nEmpty linked list");
            }
            Console.WriteLine("\nLinked list characters: ");
            while (curr != null)
            {
                Console.Write(curr.data + "->");
                curr = curr.next;
            }
            Console.WriteLine("End");
        }

        public void delete(char del)
        {
            LinkedNode prev = null;
            LinkedNode curr = head;

            if (head.data == del)
            {
                head = head.next;
            }
            else
            {
                while (curr != null)
                {
                    if (curr.data == del)
                    {
                        prev.next = curr.next;
                    }
                    prev = curr;
                    curr = curr.next;
                }
            }
        }

        // Function to delete the last occurrence  
        public void deleteLast(int x)
        {
            LinkedNode prev = null;
            LinkedNode curr = head;

            //LinkedNode temp = head , ptr = null;
            while (curr != null)
            {
                // If found key, update  
                if (curr.data == x)
                    prev = curr;
                curr = curr.next;
            }

            // If the last occurrence is the last node  
            if (prev != null && prev.next == null)
            {
                curr = head;
                while (curr.next != prev)
                    curr = curr.next;
                curr.next = null;
            }

            // If it is not the last node  
            if (prev != null && prev.next != null)
            {
                prev.data = prev.next.data;
                curr = prev.next;
                prev.next = prev.next.next;
            }
        }

        public void deleteTri(LinkedNode root)
        {
            LinkedNode curr = head;
            LinkedNode prev = head;

            //Traverse through the list, storing the values in a dict char:num
            IDictionary<char, int> dict = new Dictionary<char, int>();
            while (curr != null )
            {
                int index = 0;

                if (dict.ContainsKey(curr.data)){
                    dict[curr.data] += 1;

                    if(dict[curr.data] > 2)
                    {
                        if(curr.next == null)
                        {
                            prev.next = null;
                        }
                        //delete the curr node
                        prev.next = curr.next;
                    }
                }
                else
                {
                    dict.Add(curr.data, 1);
                }
                index++;

                prev = curr;
                curr = curr.next;

            }
            foreach (KeyValuePair<char, int> item in dict)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

        }
    }

    
}
