using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked Lst work");

            LinkedList<string> shoppingList = new LinkedList<string>();
            shoppingList.Add("Milk");
            shoppingList.Add("Bread");
            shoppingList.Add("Olives");
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }
        }
    }
}
