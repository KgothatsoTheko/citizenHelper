//ST10092141 - Kgothatso Theko
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citizenHelper
{
    //Binary Search Tree (BST) for report management - will allow efficient insertion, deletion, and search operations based on the unique ReportID.
    // implementation adapted from Source Code Examples
    // https://www.sourcecodeexamples.net/2023/10/avl-tree-implementation-in-csharp.html
    // Source Code Examples
    public class AVLNode
    {
        public ReportData Data { get; set; }
        public AVLNode Left { get; set; }
        public AVLNode Right { get; set; }
        public int Height { get; set; }

        public AVLNode(ReportData data)
        {
            Data = data;
            Height = 1;
        }
    }

    public class AVLTree
    {
        public AVLNode Root { get; private set; }

        public void Insert(ReportData data)
        {
            Root = Insert(Root, data);
        }

        private AVLNode Insert(AVLNode node, ReportData data)
        {
            if (node == null)
                return new AVLNode(data);

            int compare = string.Compare(data.ReportID, node.Data.ReportID, StringComparison.Ordinal);
            if (compare < 0)
                node.Left = Insert(node.Left, data);
            else if (compare > 0)
                node.Right = Insert(node.Right, data);
            else
                throw new ArgumentException("Duplicate ReportID");

            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

            int balance = GetBalance(node);

            // Left Left Case
            if (balance > 1 && string.Compare(data.ReportID, node.Left.Data.ReportID, StringComparison.Ordinal) < 0)
                return RightRotate(node);

            // Right Right Case
            if (balance < -1 && string.Compare(data.ReportID, node.Right.Data.ReportID, StringComparison.Ordinal) > 0)
                return LeftRotate(node);

            // Left Right Case
            if (balance > 1 && string.Compare(data.ReportID, node.Left.Data.ReportID, StringComparison.Ordinal) > 0)
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }

            // Right Left Case
            if (balance < -1 && string.Compare(data.ReportID, node.Right.Data.ReportID, StringComparison.Ordinal) < 0)
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }

            return node;
        }

        public ReportData Search(string reportId)
        {
            return Search(Root, reportId);
        }

        private ReportData Search(AVLNode node, string reportId)
        {
            if (node == null)
                return null;

            int compare = string.Compare(reportId, node.Data.ReportID, StringComparison.Ordinal);
            if (compare == 0)
                return node.Data;
            else if (compare < 0)
                return Search(node.Left, reportId);
            else
                return Search(node.Right, reportId);
        }

        private int GetHeight(AVLNode node)
        {
            return node?.Height ?? 0;
        }

        private int GetBalance(AVLNode node)
        {
            if (node == null)
                return 0;
            return GetHeight(node.Left) - GetHeight(node.Right);
        }

        private AVLNode RightRotate(AVLNode y)
        {
            AVLNode x = y.Left;
            AVLNode T2 = x.Right;

            // Perform rotation
            x.Right = y;
            y.Left = T2;

            // Update heights
            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;
            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;

            // Return new root
            return x;
        }

        private AVLNode LeftRotate(AVLNode x)
        {
            AVLNode y = x.Right;
            AVLNode T2 = y.Left;

            // Perform rotation
            y.Left = x;
            x.Right = T2;

            // Update heights
            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;
            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;

            // Return new root
            return y;
        }
    }
}
