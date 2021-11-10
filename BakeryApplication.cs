/*
Name: Ciarenn Hollis
Assignment: Bakery Application - Crullers and Croissants
Tutorial by: Janell Baxter June 15th, 2020
Date: Week 3, Fall 2021
 */

using System;
using static System.Console;

namespace BakeryApplicationHW
{

        class Program
        {
            static void Main()
            {
                new Bakery();
            }
        }



    public class Bakery
    {

        public string Name;

        //Constructor
        public Bakery()
        {
            Open();
        }

        public void Open()
        {
            Title = "Crullers and Croissants Bakery";
            Console.WriteLine("Welcome to the Crullers and Croissants Bakery\n");
            Bake();
        }

        public void Bake()
        {
            string input;
            int croissantTotal = 0;
            int donutTotal = 0;
            int eclairTotal = 0;
            double total;

            Item croissant = new Item("Chocolate Croissant", "Super tasty yummy treat", 100.000034);
            Item donut = new Item("Donut", "Chocolate frosted donut", 2.799087654);
            Item eclair = new Item("Fancy E$lair", "Super fancy eclair", 400.99);

            //Display
            croissant.About();
            donut.About();
            eclair.About();

            //Sell
            Console.WriteLine("How many " + croissant.Name + " would you like?");
            input = Console.ReadLine();
            croissantTotal = Convert.ToInt32(input);

            Console.WriteLine("How many " + donut.Name + " would you like?");
            input = Console.ReadLine();
            donutTotal = Convert.ToInt32(input);

            Console.WriteLine("How many " + eclair.Name + " would you like?");
            input = Console.ReadLine();
            eclairTotal = Convert.ToInt32(input);

            total = (croissantTotal * croissant.Price) + (donutTotal * donut.Price) + (eclairTotal * eclair.Price);


            //Total
            Console.WriteLine("Total is currently " + total.ToString("c"));
            Console.ReadLine();
        }
    }

    public class Item
    {
        public string Name;
        public string Description;
        public double Price;

        //Constructor
        public Item()
        {

        }

        //Overload constructor
        public Item(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public void About()
        {
            Console.WriteLine($"{Name} ({Description}) ${Price}");
        }
    }
}
