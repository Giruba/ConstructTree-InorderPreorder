using System;

namespace ConstructTreeFromPreorderInorder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Construct Tree - Preorder and Inorder!");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Enter the Preorder array");
            int[] preorderArray = UserInputUtility.GetArrayFromUserInput();
            Console.WriteLine("Enter the Inorder array");
            int[] inorderArray = UserInputUtility.GetArrayFromUserInput();
            BinaryTree binaryTree = new BinaryTree(null);
            binaryTree.SetBinaryTreeRoot(
            binaryTree.ConstructTreeFromPreorderInorderArray(binaryTree.GetBinaryTreeRoot(),
                preorderArray, inorderArray, 0, 0, preorderArray.Length-1));
            Console.WriteLine();
            Console.WriteLine("--- Result in Inorder traversal ---");
            binaryTree.InorderTraversalOfTree(binaryTree.GetBinaryTreeRoot());
            Console.ReadLine();
        }
    }
}
