using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treenode : MonoBehaviour
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Solution
    {
        int max = 0;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            this.Helper(root);
            return max;
        }

        public int Helper(TreeNode root)
        {
            if (root == null) return 0;
            int left = this.Helper(root.left);

            int right = this.Helper(root.right);
            max = Math.Max(max, left + right);
            return Math.Max(left, right) + 1;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Solution solution = new Solution();
        TreeNode root = new TreeNode(5);
        solution.DiameterOfBinaryTree(root);
    }

    // Update is called once per frame

}
