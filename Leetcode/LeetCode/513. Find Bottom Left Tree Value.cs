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
public class Solution
{
    public int FindBottomLeftValue(TreeNode root)
    {
        if(root == null)
            return -1;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int leftVal = 0;

        while(queue.Count > 0)
        {
            TreeNode curr = queue.Dequeue();
            
            if(curr.right != null)
                queue.Enqueue(curr.right);
            if (curr.left != null)
                queue.Enqueue(curr.left);

            leftVal = curr.val;
        }
        return leftVal;
    }
}
