using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
   
    public class Node
    {
        public int value;
        public Node left;
        public Node right;

        //Node constructor
        public Node(int data)
        {
            value = data;
            left = null;
            right = null;
        }
    }

}
