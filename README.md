# ConstructTree-InorderPreorder
C# program to construct a tree from both preorder and inorder traversals


Logic
-----
1. First node in preorder is root, so form root
2. Get the inorder position of the formed node from inorder array
3. Recurse for left by calling the funtion with start = samestart, end = inorderposition-1, preOrderindex++
4. Recurse for right by passing in start = inorderposition+1, end, preOrderIndex++
5. Print the tree using any traversal
