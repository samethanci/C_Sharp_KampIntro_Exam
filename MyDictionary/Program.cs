using System;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string> dictionary = new Dictionary<string>();
            dictionary.Add("Samet");
            dictionary.Add("Ahmet");
            Console.WriteLine(dictionary.Length);
            foreach (var isim in dictionary.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
