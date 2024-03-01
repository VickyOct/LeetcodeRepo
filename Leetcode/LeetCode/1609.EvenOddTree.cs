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
    public bool IsEvenOddTree(TreeNode root)
    {
        if (root == null)
            return false;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        int level = -1;
        queue.Enqueue(root);

        while(queue.Count > 0)
        {
            level++;
            int size = queue.Count
            int preValue = 0;

            for(int i = 0; i < size; i++)
            {
                TreeNode curr = queue.Dequeue();

                if(level == 0 && curr.val % 2 == 0)
                    return false;

                if (i == 0)
                {
                    if ((level % 2 == 1 && curr.val % 2 == 0)
                        || (level % 2 == 0 && curr.val % 2 == 1))
                    {
                        preValue = curr.val;
                    } else
                        return false;
                }
                else
                {
                    if(level % 2 == 0)
                    {
                        if(curr.val % 2 == 1 && preValue < curr.val)
                            preValue = curr.val;
                        else
                            return false;
                    }
                    else
                    {
                        if (curr.val % 2 == 0 && preValue > curr.val)
                            preValue = curr.val;
                        else
                            return false;
                    }
                }

                if(curr.left != null)
                    queue.Enqueue(curr.left);
                
                if(curr.right != null)
                    queue.Enqueue(curr.right);
            }
        }
        return true;
    }
}
