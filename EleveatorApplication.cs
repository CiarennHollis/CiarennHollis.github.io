//Name: Ciarenn Hollis
//Date: 10 November 2021 - Fall Semester PROG 101
//Description: An app that simiulates riding an elevator (based off a demo from week 10's class)

using System;
using static System.Console;
using System.Threading;

namespace ElevatorDemoInClass
{
    class Program
    {
        public static void Main()
        {
            Console.Title = ("Elevator");


            WriteLine("Which elevator are you getting on?");
            int elevatornumber = Convert.ToInt32(Console.ReadLine());

            WriteLine("What is your current floor?");
            int currentfloor = Convert.ToInt32(Console.ReadLine());

            WriteLine("What floor are you going to?");
            int requestedfloor = Convert.ToInt32(Console.ReadLine());
            Clear(); 

            //Instantiating the Elevator
            Elevator myElevator1 = new Elevator(elevatornumber, currentfloor, requestedfloor);

            //Interacting with the Elevator
            myElevator1.Check();
            myElevator1.Boarding();
            myElevator1.Riding();
            

        }
    }

    public class Elevator
    {
        //variables
        int NumberOfFloors;
        int CurrentFloor;
        int RequestedFloor;
        int ElevatorNumber;
        //int WeightLimit;
        //int Capacity;
        //string Make;
        //string Model;
        int MinNumberOfPassengers;
        int MaxNumberOfPassengers;

        
        //constructors
        public Elevator(int eNumber, int cFloor, int rFloor)
        {
            this.NumberOfFloors = 18;
            this.MinNumberOfPassengers = 0;
            this.MaxNumberOfPassengers = 10;

            this.ElevatorNumber = eNumber;
            this.CurrentFloor = cFloor;
            this.RequestedFloor = rFloor;
        }

        //actions
        public void Check()
        {
            //random number generator
            var rand = new Random();
            int NumberOfPassengers = rand.Next(MinNumberOfPassengers, MaxNumberOfPassengers);
            Console.WriteLine($"There is/are {NumberOfPassengers} passenger(s) on this elevator. \nYou may get on this one. \n ");
            Thread.Sleep(2000);

            if (NumberOfPassengers == MaxNumberOfPassengers)
            {
                Console.WriteLine("There are too many passengers on this elevator. \n Please wait for the next one.");
                Thread.Sleep(3000);
                Clear();
                Program.Main();
            }
        }
        public void Boarding()
        {
            if (CurrentFloor > NumberOfFloors || CurrentFloor < 1)
            {
                Console.WriteLine($"Please choose from floors 1 to {NumberOfFloors} as your CURRENT FLOOR and REQUEST FLOOR.");
                Console.ReadLine();
                Clear();
                Program.Main();
            }

            Console.WriteLine($"You have entered Elevator {ElevatorNumber} from floor {CurrentFloor}. ");
            Thread.Sleep(1500);
            Console.WriteLine($"You are heading to floor {RequestedFloor}. \n");
            Thread.Sleep(5000);
            
        }
        public void Riding()
        {
            if (CurrentFloor < RequestedFloor)
            {
               while (CurrentFloor < RequestedFloor)
               {
                    Ascend();
               }

               Stop();

            }
            else if (CurrentFloor > RequestedFloor)
            {
                while (CurrentFloor > RequestedFloor)
                {
                    Descend();
                }

                Stop();
                
            }
                        
        }
        void Ascend()
        {
            Thread.Sleep(2000);
            CurrentFloor = CurrentFloor + 1;
            Console.WriteLine($"  Floor {CurrentFloor}.");
        }
        void Descend()
        {
            Thread.Sleep(2000);
            CurrentFloor = CurrentFloor - 1;
            Console.WriteLine($"  Floor {CurrentFloor}.");
        }
        void Stop()
        {
            Console.WriteLine("You have reached your destination.");
            Thread.Sleep(2000);
            Console.WriteLine($"Press [ENTER] to exit Elevator {ElevatorNumber}.");
            Console.ReadLine();
            Thread.Sleep(1500);
            System.Environment.Exit(1);
        }

    }
}
