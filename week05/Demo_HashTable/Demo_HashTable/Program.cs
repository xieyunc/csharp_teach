using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Demo_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable(); 
            hashtable.Add("id", "BH0001"); 
            hashtable.Add("name", "TM");
            //hashtable.Add("id", "BH0002");
            foreach (DictionaryEntry dicEntry in hashtable)
              Console.WriteLine("\t " + dicEntry.Key + "\t " + dicEntry.Value);

            Console.WriteLine(hashtable.ContainsValue("id"));
            System.Console.ReadKey();
        }
        
    }
}
