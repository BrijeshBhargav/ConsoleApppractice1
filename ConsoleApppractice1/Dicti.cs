using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApppractice1
{

    internal class Dicti
    {
        public void tes()
        {
            SortedDictionary<int, string> obj = new SortedDictionary<int, string>();

            // Adding key/value pair in Sorted 
            // Dictionary Using Add() method
            obj.Add(1, "Ask.com");
            obj.Add(003, "Yahoo");
            obj.Add(001, "Google");
            obj.Add(005, "AOL.com");
            obj.Add(002, "Bing");
            Console.WriteLine("Top Search Engines:");

            // Accessing the key/value pair of the 
            // SortedDictionary Using foreach loop
            foreach (KeyValuePair<int, string> pair in obj)
            {
                Console.WriteLine("Rank: {0} and Name: {1}",
                                      pair.Key, pair.Value);
            }

        }

    }
}


    
