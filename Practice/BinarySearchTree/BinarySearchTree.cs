using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.BinarySearchTree
{
    public class BinarySearchTree
    {
        private TreeNode? Root { get; set; } = null;

        public void Insert(int key, string value)
        {
           Root = Insert(Root, key, value);
        }

        public TreeNode? Insert(TreeNode node, int key, string value)
        {
            TreeNode newNode = new TreeNode(key, value);
            if(node == null)
            {
                node = newNode;
            }
            else if(key < node.Key)
            {
                node.LeftChild = Insert(node.LeftChild, key, value);
            }
            else if(key > node.Key)
            {
                node.RightChild = Insert(node.RightChild, key, value);
            }
            return node;
        }

        public TreeNode Find(int key)
        {
            TreeNode? node = Find(Root, key);
            return node == null ? null : node;
        }

        public TreeNode? Find(TreeNode? node, int key)
        {
            if(node == null || node.Key == key)
            {
                return node;
            }else if(key < node.Key)
            {
                return Find(node.LeftChild, key);
            }else if(key > node.Key)
            {
                return Find(node.RightChild, key);
            }
            return null;
        }
    }
}
