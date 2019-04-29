using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Binary Tree implementation");
            Console.WriteLine("---------------------------");

            //Binary tree implementation
            Node root = new Node(3);

            root.left = new Node(5);
            root.right = new Node(6);

            root.left.right = new Node(9);
            root.left.left = new Node(11);

            root.right.left = new Node(18);
            root.right.right = new Node(20);

            

            //Binary tree 
            Tree tree = new Tree();

            //Inorder tree traversal
            Console.Write("Tree leafs: ");
            tree.traversal(root);

            //Sum of the leafs
            Console.WriteLine("\nThe sum is: " +tree.sumLeaf(root));

            //Depth of the tree
            Console.WriteLine("The depth of the tree is: " + tree.findDepth(root, 0));

            
            Console.WriteLine("\n\nUser defined LinkedList implementation");
            Console.WriteLine("--------------------------------------");














            //Linked list implementation
            LinkedList linkedList = new LinkedList();

            LinkedNode firstNode = new LinkedNode('E');
            LinkedNode secondNode = new LinkedNode('B');
            LinkedNode thirdNode = new LinkedNode('E');
            LinkedNode forthNode = new LinkedNode('E');
            LinkedNode fithNode = new LinkedNode('B');
            LinkedNode sixthNode = new LinkedNode('A');
            LinkedNode seventhNode = new LinkedNode('B');

            linkedList.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = forthNode;
            forthNode.next = fithNode;
            fithNode.next = sixthNode;
            sixthNode.next = seventhNode;

            Console.Write("Number of chars in Linked list: " + LinkedNode.count);

            //Console.WriteLine(forthNode.data);
            linkedList.printList(linkedList.head);

            //linkedList.delete('B');

            //Console.Write("After deletion: " + LinkedNode.count);

            //Console.WriteLine(forthNode.data);
            linkedList.printList(linkedList.head);

            linkedList.deleteTri(linkedList.head);

            Console.Write("After deletion");
            linkedList.printList(linkedList.head);

            Console.WriteLine("\n\nSystem defined LinkedList implementation");
            Console.WriteLine("----------------------------------------");

            //Inbuilt C# Linkedlist
            LinkedList<Char> linkedList2 = new LinkedList<char>();
            linkedList2.AddLast('A');
            linkedList2.AddLast('B');
            linkedList2.AddLast('A');
            linkedList2.AddLast('C');

            Console.WriteLine("Number of chars in Linked list: " + linkedList2.Count);
            Console.Write("Linked list characters: ");
            foreach (char i in linkedList2)
            {
                Console.Write(i + "->");
            }
            Console.WriteLine("End");

            linkedList2.Remove('A');

            foreach (char i in linkedList2)
            {
                Console.Write(i + "->");
            }
            Console.WriteLine("End");

        }
    }
}
