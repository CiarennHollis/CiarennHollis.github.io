//Name: Ciarenn Hollis
//Assignment: Programming I practice
//Tutorial by: programmingisfun.com
//Date: Week 3, Fall 2021

using System;

namespace TenBears
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Ten Bears";

            for (int currentBears = 10; currentBears > 1; currentBears--)
            {
                Console.WriteLine(currentBears + " bears in the bed and the little one said \"I'm crowded... roll over...\"");
                Console.WriteLine("So they all rolled over and one fell out...\n");
            }

            Console.WriteLine("One bear in the bed and the little one said \"I'm lonely\"");
            MakeBear();

            Console.ReadLine();

        }

        static void MakeBear()
        {
            string bear = @"
 {''-''}
  (o o)
,--`Y'--.
``:   ;''
  / _ \
 ()' `()

";
            Console.WriteLine(bear);
        }
    }
}
