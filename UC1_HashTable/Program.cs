using System;
using System.Collections.Generic;

namespace UC1_HashTable
{
    public class program
    {
        static void main(string[] args)
        {
            Console.WriteLine("Sentence like: ");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");

            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value: " + hash5);
        }
    }
}
