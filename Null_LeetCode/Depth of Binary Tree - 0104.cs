using System;

namespace Null_LeetCode;

public class DepthOfBinaryTree
{
    public int Depth(TreeNode root)
    {
        if (root == null) return 0;

        return 1 + Math.Max(Depth(root.left), Depth(root.right));
    }
}