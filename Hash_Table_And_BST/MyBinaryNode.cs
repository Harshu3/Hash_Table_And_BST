using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_And_BST
{
    class MyBinaryNode<T> where T : IComparable
    {
        public T NodeData { get; set; }
        public MyBinaryNode<T> Left { get; set; }
        public MyBinaryNode<T> Right { get; set; }
        
        public MyBinaryNode(T nodeData)
        {
            this.NodeData = nodeData;
            this.Left = null;
            this.Right = null;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
        
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.Left == null)
                    this.Left = new MyBinaryNode<T>(item);
                else
                    this.Left.Insert(item);
            }
            else
            {
                if (this.Right == null)
                    this.Right = new MyBinaryNode<T>(item);
                else
                    this.Right.Insert(item);
            }
        }

        public void Display()
        {
            if (this.Left != null)
            {
                this.leftCount++;
                this.Left.Display();
            }
            Console.Write(" " + this.NodeData.ToString());
            if (this.Right != null)
            {
                this.rightCount++;
                this.Right.Display();
            }
        }

        public void GetSize()
        {
            Console.WriteLine("\nSize of binary tree" + " " + (1 + this.leftCount + this.rightCount));
        }

    }
}
