//Add to using directives
using System.Console;
using System.Threading;

//the class, copy and paste this into the namespace
    //streamlining console methods 
    class Utility
    {
        //Method for "press enter to contue"
        public static void WaitForKeyPress()
        {
            Console.WriteLine("Press [ENTER] to continue.");
            Console.ReadLine();
        }


        //Method for streamlining waiting for a certain amount of seconds
        public static void WaitForTime(int seconds)
        {
            int milliseconds = seconds * 1000;
            Console.WriteLine($"Waiting for {seconds} seconds.");

            Thread.Sleep(milliseconds);
            
            //to input this into Main to run a program that asks for seconds:
            //Console.WriteLine("How many seconds would you like to wait for?");
            //Utility.WaitForTime(Convert.ToInt32(Console.ReadLine()));

        }
    }
