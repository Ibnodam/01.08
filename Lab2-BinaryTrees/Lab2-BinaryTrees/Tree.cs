using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_BinaryTrees
{
    public class Tree
    {
        public TreeNode Root;

        public Tree(TreeNode root)
        {
            Root = root;
        }
        public int SumOfLeaves(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            if (node.Left == null && node.Right == null)
            {
                return node.Value;
            }

            return SumOfLeaves(node.Left) + SumOfLeaves(node.Right);
        }
    }

}
