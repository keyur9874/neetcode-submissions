/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    int maxDiameter = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        Height(root);
        return maxDiameter;
    }

    private int Height(TreeNode root) {
        if (root == null)
            return 0;

        int leftDepth = Height(root.left);
        int rightDepth = Height(root.right);
        maxDiameter = Math.Max(leftDepth + rightDepth, maxDiameter);

        return Math.Max(leftDepth, rightDepth)+1;
    }
}
