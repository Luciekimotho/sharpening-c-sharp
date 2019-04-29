using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Tree {

        public Node root;
        public int sum = 0;

        public Tree()
        {
            root = null;
        }

        public void traversal(Node root)
        {
            if (root == null)
            {
                return;
            }
            traversal(root.left);
            Console.Write(root.value + ",");
            traversal(root.right);
        }
        public int findDepth(Node node, int depth)
        {
            if (node == null)
            {
                return depth;
            }
            int leftDepth = findDepth(node.left, depth++);
            int rightDepth = findDepth(node.right, depth++);

            return Math.Max(leftDepth, rightDepth);
        }

        public int sumLeaf(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            sumLeaf(root.left);
            sum = sum + root.value;
            sumLeaf(root.right); 

            return sum;

        }

        
    }
    

}
