using System;

namespace Hash_Table_And_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table and Binary Search Tree Program!");
            Console.WriteLine("Creating a Binary Search Tree");
            Console.WriteLine("Added nodes are");
            MyBinaryNode<int> bt = new MyBinaryNode<int>(56);
            bt.Insert(30);
            bt.Insert(76);
            bt.Display();
            bt.GetSize();
        }
    }
}