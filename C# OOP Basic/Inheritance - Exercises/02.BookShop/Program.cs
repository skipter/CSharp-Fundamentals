﻿using System;

namespace _02.BookShop
{
    public class Program
    {
        static void Main()
        {
            try
            {
                string author = Console.ReadLine();
                string title = Console.ReadLine();
                decimal price = decimal.Parse(Console.ReadLine());

                Book book = new Book(author, title, price);
                GoldenEditionBook goldBook = new GoldenEditionBook(author, title, price);

                Console.WriteLine(book);
                Console.WriteLine();
                Console.WriteLine(goldBook);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
