﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Program
    {
        public static void CountNumbOfOccurence(string paragraph)
        {
            MyMapNode1.MyMapNode<string, int> hashTabe = new MyMapNode1.MyMapNode<string, int>(6);
            string[] words = paragraph.Split(' ');
            foreach (string word in words)
            {
                if (hashTabe.Exists(word.ToLower()))
                    hashTabe.Add(word.ToLower(), hashTabe.Get(word.ToLower()) + 1);
                else
                    hashTabe.Add(word.ToLower(), 1); //to,1 
            }
            Console.WriteLine("Please find below words with its frequency of occurrence's :- ");
            hashTabe.Display();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Demo Program on HashTables in DSA .\n");
            Console.WriteLine("Please sslect any one from below given options :\n" +
                "1 : Checking frequency of occurence of words in a single line statement (UC1).");
            int option = Convert.ToInt32((string)Console.ReadLine());
            switch (option)
            {
                //UC1 (Counting frequency of occurrence of words in a sentence).
                case 1:
                    string paragraph = "To be or not to be";
                    CountNumbOfOccurence(paragraph);
                    break;
                default:
                    Console.WriteLine("Invalid option selected ! Please try again .");
                    break;
            }
            Console.ReadLine();
        }
    }
}
