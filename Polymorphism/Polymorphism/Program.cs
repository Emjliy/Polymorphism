using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kitab sayi:");
            int size = int.Parse(Console.ReadLine());
            Book[] book = new Book[size];
            for (int i = 0; i < size; i++)
            {
                Book[] books = new Book[size];
                books[i].No = Convert.ToInt32(Console.ReadLine());
                books[i].Name = Console.ReadLine();
                books[i].Price = Convert.ToDouble(Console.ReadLine());
                books[i].Genre = Console.ReadLine();
            }
            Console.WriteLine("1.Filter");
            Console.WriteLine("2.Show all books");
            Console.WriteLine("3.Close the program");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                int minPrice = Convert.ToInt32(Console.ReadLine());
                int maxPrice = Convert.ToInt32(Console.ReadLine());
                Array.Sort(book);
                Book[] sort = new Book[book.Length];
                Console.WriteLine(sort);

            }
            else if (input == 2)
            {
                Console.WriteLine(book);
            }
            else
            {
                Console.WriteLine();
            }
        }


    }
}
