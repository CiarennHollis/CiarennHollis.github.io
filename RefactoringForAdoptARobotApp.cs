/* Adopt A Robot
 * Example code for PROG 101
 * Originally created by Janell Baxter
 * Game class refactored by _Ciarenn Hollis_
 * Fall 2021
 */

//Note: this code isn't mine, my contribution to this code was reorganizing it into separate classes.

using System;
using static System.Console;

namespace Adopt_a_Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game("Super Awesome Adopt-a-Bot Game!");
            game.Start();
        }
    }

    class Game
    {
        Player player;
        string GameTitle = "Adopt a bot!";

        public Game()
        {
            player = new Player();
        }
        public Game(string title)
        {
            GameTitle = title;
            player = new Player();
        }

        public void Start()
        {
            Title = GameTitle;

            // DONE Get player's name and save it to the instance of player class
            WriteLine("Welcome to Adopt a Robot!");
            WriteLine("What is your name?");
            player.Name = ReadLine();




            // DONE greet player with the name they entered
            // DONE WriteLine("Glad to meet you " + player.Name);

            // DONE WriteLine($"You are adopting a robot.");
            WriteLine(player.PlayerGreeting());


            // DONE get name for player's robot
            WriteLine("What name would you like your robot to have?");
            player.PlayerRobot.Name = ReadLine();

            // DONE get color for robot
            player.RobotColorChoice();

            // DONE print summary of player's robot (name and color)
            Clear();
            WriteLine($"Congratulations {player.Name}! You have adopted a {player.PlayerRobot.Color} robot named {player.PlayerRobot.Name}. Press any key to exit.");
            ReadKey();

        }
    }

    class Robot
    {
        public string Name;
        public string Color;

        public Robot(string name, string color)
        {
            Name = name;
            Color = color;


        }



    }

    class Player
    {
        public string Name;
        public Robot PlayerRobot;

        public Player()
        {

            PlayerRobot = new Robot("Robot Mach II", "Silver");
        }

        public string PlayerGreeting()
        {
            return $"Glad to meet you {this.Name}. You are adoptong a robot!";


        }

        public string RobotColorChoice()
        {
            WriteLine("Type a number for a color: 1) Blue 2) Purple 3) Green 4) Brown 5) Black 6)Coral ");
            string choice = ReadLine();
            switch (choice)
            {
                case "1":
                    PlayerRobot.Color = "blue";
                    break;
                case "2":
                    PlayerRobot.Color = "purple";
                    break;
                case "3":
                    PlayerRobot.Color = "green";
                    break;
                case "4":
                    PlayerRobot.Color = "brown";
                    break;
                case "5":
                    PlayerRobot.Color = "black";
                    break;
                case "6":
                    PlayerRobot.Color = "coral";
                    break;
                default:
                    PlayerRobot.Color = "silver";
                    break;
            }

            return PlayerRobot.Color;

        }

    }
}
