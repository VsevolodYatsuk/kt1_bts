class BST_vis_run
{
    static void Main(string[] args)
    {
        BST bst = new BST();

        int[] anArrayNodes = {
            17, 6, 5, 20, 19, 18, 11, 14, 12, 13, 2, 4, 10
        };

        for (int i = 0; i < anArrayNodes.Length; i++)
        {
            bst.Insert(anArrayNodes[i]);
        }

        bst.Visualize();


        Console.Write("In-order Traversal: ");
        bst.InOrderTraversal();

        Console.Write("Pre-order Traversal: ");
        bst.PreOrderTraversal();
    }
}
