namespace Null_LeetCode;

public class InvertBinaryTree
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root != null)
        {
            InvertTree(root.left);
            InvertTree(root.right);
            (root.left, root.right) = (root.right, root.left);
        }
        
        return root;
    }
}

public class TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
{
    public int val = val;
    public TreeNode left = left;
    public TreeNode right = right;
}