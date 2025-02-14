using Lab2_BinaryTrees;


    TreeNode root = new TreeNode(1);
    root.Left = new TreeNode(2);
    root.Right = new TreeNode(3);
    root.Left.Left = new TreeNode(4);
    root.Left.Right = new TreeNode(5);
    root.Right.Right = new TreeNode(6);

    Tree tree = new Tree(root);

    int sum = tree.SumOfLeaves(tree.Root);
    Console.WriteLine($"Сумма значений всех листьев: {sum}");