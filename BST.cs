using System;

public class BST
{
    public BSTNode root;

    public void Insert(int key)
    {
        root = InsertHelper(root, key);
    }

    private BSTNode InsertHelper(BSTNode root, int key)
    {
        if (root == null)
        {
            return new BSTNode(key);
        }

        if (key < root.key)
        {
            root.left = InsertHelper(root.left, key);
        }
        else if (key > root.key)
        {
            root.right = InsertHelper(root.right, key);
        }

        return root;
    }

    public void Visualize()
    {
        VisualizeHelper(root, " ", true);
    }

    private void VisualizeHelper(BSTNode node, string prefix, bool isLeft)
    {
        if (node == null)
        {
            return;
        }

        string nodeStr = node.key.ToString();
        string line = prefix + (isLeft ? "├── " : "└── ");
        Console.WriteLine(line + nodeStr);

        string childPrefix = prefix + (isLeft ? "│   " : "    ");
        VisualizeHelper(node.left, childPrefix, true);
        VisualizeHelper(node.right, childPrefix, false);
    }

    public void InOrderTraversal()
    {
        InOrderTraversalHelper(root);
        Console.WriteLine();
    }

    private void InOrderTraversalHelper(BSTNode node)
    {
        if (node != null)
        {
            InOrderTraversalHelper(node.left);
            Console.Write(node.key + " ");
            InOrderTraversalHelper(node.right);
        }
    }

    public void PreOrderTraversal()
    {
        PreOrderTraversalHelper(root);
        Console.WriteLine();
    }

    private void PreOrderTraversalHelper(BSTNode node)
    {
        if (node != null)
        {
            Console.Write(node.key + " ");
            PreOrderTraversalHelper(node.left);
            PreOrderTraversalHelper(node.right);
        }
    }
}

