using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructTreeFromPreorderInorder
{
    class BinaryTree
    {
        BinaryTreeNode root;

        public BinaryTree(BinaryTreeNode binaryTreeNode) {
            root = binaryTreeNode;
        }

        public void SetBinaryTreeRoot(BinaryTreeNode binaryTreeNode) {
            root = binaryTreeNode;
        }

        public BinaryTreeNode GetBinaryTreeRoot() {
            return root;
        }

        public BinaryTreeNode InsertInBinaryTree(BinaryTreeNode binaryTreeNode, int data) {
            if (binaryTreeNode == null) {
                binaryTreeNode = new BinaryTreeNode(data);
                return binaryTreeNode;
            }

            if (binaryTreeNode.GetBinaryTreeNodeData() < data)
            {
                binaryTreeNode.SetBinaryTreeNodeRight(
                    InsertInBinaryTree(binaryTreeNode.GetBinaryTreeNodeRight(), data));
            }
            else {
                binaryTreeNode.SetBinaryTreeNodeLeft(
                    InsertInBinaryTree(binaryTreeNode.GetBinaryTreeNodeLeft(), data));
            }
            return binaryTreeNode;
        }

        public BinaryTreeNode ConstructTreeFromPreorderInorderArray(BinaryTreeNode binaryTreeNode,
            int[] preOrderArray, int[] inorderArray, int preOrderIndex,  int startPosition,  int endPosition){

            if (startPosition > endPosition) {
                return binaryTreeNode;
            }

            binaryTreeNode = new BinaryTreeNode(preOrderArray[preOrderIndex++]);

            if (startPosition == endPosition) {
                return binaryTreeNode;
            }

            int inorderPosition = SearchInInorderArray(inorderArray, startPosition, endPosition, binaryTreeNode.GetBinaryTreeNodeData());

            binaryTreeNode.SetBinaryTreeNodeLeft(
                ConstructTreeFromPreorderInorderArray(
                    binaryTreeNode.GetBinaryTreeNodeLeft(), preOrderArray, inorderArray, preOrderIndex, startPosition, inorderPosition-1));

            binaryTreeNode.SetBinaryTreeNodeRight(
                ConstructTreeFromPreorderInorderArray(
                binaryTreeNode.GetBinaryTreeNodeRight(), preOrderArray, inorderArray, preOrderIndex, inorderPosition+1, endPosition));
            return binaryTreeNode;
        }

        public int SearchInInorderArray(int[] inorderArray, int startPosition, int endPosition, int value){

            for (int index = startPosition; index < endPosition; index++) {
                if (inorderArray[index] == value) {
                    return index;
                }
            }

            return -1;
        }

        public void InorderTraversalOfTree(BinaryTreeNode binaryTreeNode) {
            if (binaryTreeNode == null) {
                return;
            }

            InorderTraversalOfTree(binaryTreeNode.GetBinaryTreeNodeLeft());
            Console.Write(binaryTreeNode.GetBinaryTreeNodeData()+ " ");
            InorderTraversalOfTree(binaryTreeNode.GetBinaryTreeNodeRight());
        }
    }
}
