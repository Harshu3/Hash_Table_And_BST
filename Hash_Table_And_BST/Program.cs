using System;

namespace Hash_Table_And_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table and Binary Search Tree Program!");
            Console.WriteLine("Program to find Frequency of Words in a Large Paragraph");
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            Console.WriteLine(paragraph);
            paragraph = paragraph.ToLower();
            CountNumbOfOccurence(paragraph);
        }

        private static void CountNumbOfOccurence(string paragraph)
        {
            MyMapNode<string, int> hashTabe = new MyMapNode<string, int>(6);

            string[] words = paragraph.Split(' ');

            foreach (string word in words)
            {
                if (hashTabe.Exists(word))
                    hashTabe.Add(word, hashTabe.Get(word) + 1);
                else
                    hashTabe.Add(word, 1); //to,1 
            }
            Console.WriteLine("\nFrequency of words are");
            hashTabe.Display();
        }
    }
}