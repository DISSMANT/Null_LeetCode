using System;

namespace Null_LeetCode;

public class DiameterOfBinaryTree0543
{
    private int bestDiagonal = 0;
    public int DiameterOfBinaryTree(TreeNode root)
    {
        DFS(root);
        return bestDiagonal;
    }

    private int DFS(TreeNode root)
    {
        if (root == null) return -1;
        var left = DFS(root.left);
        var right = DFS(root.right);

        bestDiagonal = Math.Max(bestDiagonal, 2 + left + right);

        return 1 + Math.Max(left, right);
    }
}