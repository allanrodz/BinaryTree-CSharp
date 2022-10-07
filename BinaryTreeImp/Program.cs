using System;

namespace BinaryTreeImp
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();

            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(7);
            binaryTree.Add(3);
            binaryTree.Add(10);
            binaryTree.Add(5);
            binaryTree.Add(8);

            Node<int> node = binaryTree.Find(5);
            int depth = binaryTree.GetTreeDepth();
            
            Console.WriteLine($"Depth: {depth}");

            Console.WriteLine("PreOrder Traversal:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("InOrder Traversal:");
            binaryTree.TraverseInOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal:");
            binaryTree.TraversePostOrder(binaryTree.Root);
            Console.WriteLine();

            binaryTree.Remove(7);
            binaryTree.Remove(8);

            Console.WriteLine("PreOrder Traversal After Removing Operation:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            
        }
    }
}
