using System;

namespace California
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create custom linked list
            var collection = new LinkedItem<string>();

            //Add the nodes
            collection.Add("first");
            collection.Add("second");
            collection.Add("third");
            collection.Add("fourth");

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
