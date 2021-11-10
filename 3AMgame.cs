//Assignment: Midterm Project - Adventure Game
//Title: 3AM
//Name: Ciarenn Hollis
//Date: 2 November 2021, Fall Semester 2021

//~Credits~
//Title Design: https://patorjk.com/software/taag/#p=display&f=Slant%20Relief&t=Type%20Something%20
//Flower Designs from: http://loveascii.com/flowers2.html
//Jar Design adapted from: https://asciiart.website/index.php?art=objects/bottles


//systems in use
using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

//Program
namespace _3AMgameProject
{
    class Program
    {

        //where the program runs
        static void Main(string[] args)
        {
            //list for metagame
            List<string> ShoppingList = new List<string>();

            //random number generator for the cost of the player's shopping list
            var rand = new Random();
            double min = 5;
            double max = 14;
            double range = max - min;
            double PurchaseCost = rand.NextDouble();
            double scaled = (PurchaseCost * range) + min;
            float f = (float)scaled;
            double ScaledPurchaseCost = Math.Round(f, 2);

            //Title
            Console.Title = "3 AM";

            //Metagame - opening
            Console.WriteLine("What do you need from the Gas Station at this hour?");
            ShoppingList.Add(Console.ReadLine());
            Console.WriteLine("What else do you need from the Gas Station at this hour?");
            ShoppingList.Add(Console.ReadLine());
            Console.WriteLine("What's one last thing you need from the Gas Station right now?");
            ShoppingList.Add(Console.ReadLine());

            //the game itself
            // the intro, the main game play is accesses through the menu
            Game.StartGame();
            Game.Menu();

            //Metagame - ending
            Console.WriteLine("JACK: Hello.");
            Thread.Sleep(3000);
            Console.WriteLine($"JACK: *waves a hand in front of {Game.PlayerName}'s face* Hhhheeelllooo.");
            Thread.Sleep(3000);
            Console.WriteLine("  ");
            Console.WriteLine($" {Game.PlayerName} blinks. The Gas Station comes back into focus.");
            Thread.Sleep(3000);
            Console.WriteLine("JACK is leaning towards you, an annoyed look has taken up residence on his face.");
            Console.WriteLine("The sketchpad beside JACK isn't filled with strange drawings, but with random doodle of shapes and cartoons.");
            Console.WriteLine($" {Game.PlayerName} looks around. There's no one else in the store but the two of them. JESSIE and JOHN are gone.");
            Thread.Sleep(7000);
            Console.WriteLine("JACK: Hey, is everything ok?");
            Thread.Sleep(3000);
            Console.WriteLine($" {Game.PlayerName}: Uhh? Oh, um... yes.");
            Thread.Sleep(3000);
            Console.WriteLine("JACK: Ok. ");
            Thread.Sleep(5000);
            Console.WriteLine($"JACK: Your total is ${ScaledPurchaseCost}.");
            Thread.Sleep(5000);
            Console.WriteLine($" {Game.PlayerName}: Alright. *pays*.");
            Thread.Sleep(3000);
            Console.WriteLine($"JACK puts bags the purchases: {ShoppingList[0]}, {ShoppingList[1]}, and {ShoppingList[2]}. He hands over the bag.");
            Thread.Sleep(5000);

            Console.Clear();
            Console.WriteLine($" {Game.PlayerName} leaves the store and starts walking home, still disoriented.");
            Thread.Sleep(5000);
            Console.WriteLine(" Was it all a dream?");
            Thread.Sleep(5000);
            Console.WriteLine(" Was It really there?");
            Thread.Sleep(1500);
            Console.WriteLine(" In the Gas Station bathroom?");
            Thread.Sleep(5000);
            Console.WriteLine(" Or was it just 3AM delirium?");
            Thread.Sleep(7000);

            Console.WriteLine("  ");
            Console.WriteLine($" {Game.PlayerName} gets home. The house is quiet.");
            Thread.Sleep(5000);

            //Checks if the player made a jar during the game.
            //the ending changes a little depending on whether or not they did.
            if (JESSIESactions.JarCount != 0)
            {
                Console.WriteLine(" They start taking off their jacket and hears the sound of glass clanking together from on of the pocekts.");
                Thread.Sleep(5000);
                Console.WriteLine(" They reach their hand into the pocket.");
                Thread.Sleep(7000);

                Console.Clear();
                Console.WriteLine($" They find the {JESSIESactions.JarCount} lucky charms they made with JESSIE.");
            }



            //Credits roll
            Game.Credits();
            
        }



    }

    class Game
    {
        //Variables
        public static string PlayerName = "John Doe";

        static int Choice;
        public static bool Trapped = true;



        //Introductary Menu prompt
        static string MenuPrompt = @"
 The gas station is dark when you enter.
 A glow eminates from the bathroom at the back corner, 
 lighting the space with a purple glow (IT).

 Three figures catch your eye.
 One sits behind the cashier's counter off to the left (JACK).
 One is shuffling around by the bathroom, seemingly emptying a
 a that's full of something (JOHN).
 The last roams around the aisles of the store. It seems like their wearing a witch hat (JESSIE).";

        //Choices for the Menu selection
        static string PossibleChoices = @"
 1) Check out the glowing door/talk to IT
 2) Talk to JACK
 3) Talk to JESSIE
 4) Talk to JOHN
 5) LEAVE";


        //Starts the game
        public static void StartGame()
        {

            NameCharacter();
            GameIntro();

        }

        //Sets up the character
        static void NameCharacter()
        {
            Console.WriteLine(" What is your name?");
            PlayerName = Console.ReadLine();

            Console.WriteLine($" {PlayerName}, hello.");
            Thread.Sleep(3000);
        }

        //the game's intro
        static void GameIntro()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(2000);


            Console.BackgroundColor = ConsoleColor.Gray;
            Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("  2:54");
            Thread.Sleep(2000);
            Console.WriteLine("  2:55");
            Thread.Sleep(2000);
            Console.WriteLine("  2:56");
            Thread.Sleep(3500);

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Clear();
            Console.WriteLine(@" 2:54
 2:55
2:56");
            Console.ForegroundColor = ConsoleColor.Magenta;

            Thread.Sleep(2000);
            Console.WriteLine("  2:57");
            Thread.Sleep(2000);
            Console.WriteLine("  2:58");
            Thread.Sleep(2000);
            Console.WriteLine("  2:59");
            Thread.Sleep(3500);

            Console.BackgroundColor = ConsoleColor.Black;
            Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@" 2:55
 2:56
 2:57
 2:58
2:59
 ");
            Console.WriteLine("  The aura changes inside the gas station.");
            Thread.Sleep(2000);
            Console.WriteLine("  The LED bleached colors take on a purple hue.");
            Thread.Sleep(3500);

            Clear();
            ShowTitle();
            Thread.Sleep(5000);

            Console.WriteLine("                              Press to [ENTER] to Start");
            Console.ReadLine();
            Clear();

        }

        //Shows the title
        static void ShowTitle()
        {
            string title = @"

_____/\\\\\\\\\\________________/\\\\\\\\\_____/\\\\____________/\\\\_        
 ___/\\\///////\\\_____________/\\\\\\\\\\\\\__\/\\\\\\________/\\\\\\_       
  __\///______/\\\_____________/\\\/////////\\\_\/\\\//\\\____/\\\//\\\_      
   _________/\\\//_____________\/\\\_______\/\\\_\/\\\\///\\\/\\\/_\/\\\_     
    ________\////\\\____________\/\\\\\\\\\\\\\\\_\/\\\__\///\\\/___\/\\\_    
     ___________\//\\\___________\/\\\/////////\\\_\/\\\____\///_____\/\\\_   
      __/\\\______/\\\____________\/\\\_______\/\\\_\/\\\_____________\/\\\_  
       _\///\\\\\\\\\/_____________\/\\\_______\/\\\_\/\\\_____________\/\\\_ 
        ___\/////////_______________\///________\///__\///______________\///__
                            
";
            Console.WriteLine(title);
            Thread.Sleep(2000);
            Console.WriteLine("                              ~In the Gas Station~");
            Thread.Sleep(2000);


        }

        //the Menu selection/ player can choose a path
        public static void Menu()
        {


            Console.WriteLine(MenuPrompt);
            Thread.Sleep(10000);

            Console.WriteLine(PossibleChoices);
            Console.WriteLine("What would you like to do?");
            Choice = Convert.ToInt32(Console.ReadLine());


            if (Choice == 5 && Trapped == false)
            {

                //exit
                End();
            }
            else if (Choice == 1)
            {
                Console.Clear();
                ItsActions.TalkingToIT();
                Console.Clear();
                MenuV2();
            }
            else if (Choice == 2)
            {
                //call to Jack's method
                Console.Clear();
                JACKactions.JackInteraction();
                Console.Clear();
                MenuV2();
            }
            else if (Choice == 3)
            {
                //call to Jessie's method
                Console.Clear();
                JESSIESactions.JessieInteraction();
                Console.Clear();
                MenuV2();
            }
            else if (Choice == 4)
            {
                //call to James' interaction method
                Console.Clear();
                JOHNSactions.JohnInteraction();
                Console.Clear();
                MenuV2();
            }
            else if (Choice == 5 && Trapped == true)
            {
                //what happenes when the play tries to leave the gas station 
                // or leave the game without having accomplished the goal
                Console.WriteLine("You may not leave.");
                Thread.Sleep(2000);
                Console.WriteLine("Not yet.");
                Thread.Sleep(5000);
                Console.Clear();
                MenuV2();
            }

        }


        //second menu navigation
        /// <summary>
        /// essetially the same as the Menu()
        /// but without the intro Menu() has
        /// </summary>
        public static void MenuV2()
        {
            Console.WriteLine(PossibleChoices);
            Console.WriteLine("What would you like to do?");
            Choice = Convert.ToInt32(Console.ReadLine());


            if (Choice == 5 && Trapped == false)
            {
                //exit
                End();
            }
            else if (Choice == 1)
            {
                Console.Clear();
                ItsActions.TalkingToIT();
                Console.Clear();
                MenuV2();
            }
            else if (Choice == 2)
            {
                //call to Jack's method
                Console.Clear();
                JACKactions.JackInteraction();
                Console.Clear();
                MenuV2();
            }
            else if (Choice == 3)
            {
                //call to Jessie's interaction method
                Console.Clear();
                JESSIESactions.JessieInteraction();
                Console.Clear();
                MenuV2();
            }
            else if (Choice == 4)
            {
                //call to James' interaction method
                Console.Clear();
                JOHNSactions.JohnInteraction();
                Console.Clear();
                MenuV2();
            }
            else if (Choice == 5 && Trapped == true)
            {
                Console.WriteLine("You may not leave.");
                Thread.Sleep(2000);
                Console.WriteLine("Not yet.");
                Thread.Sleep(5000);
                Console.Clear();
                MenuV2();
            }
        }

        //Ending sequence starts
        public static void End()
        {
            Console.WriteLine("You walk over to the doors from the back corner of the Gas Station.");
            Thread.Sleep(2000);
            Console.WriteLine("The Gas Station has returned to it's normal aesthetic.");
            Thread.Sleep(2000);
            Console.WriteLine("The glow emminating from the Gas Station bathroom door fades away.");
            Thread.Sleep(2000);
            Console.WriteLine("Jack, Jessie, and John watch you as you pass them.");
            Thread.Sleep(2000);
            Console.WriteLine("You push the doors opens and...");
            Thread.Sleep(2000);
            Console.WriteLine("...everything fades to...");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("white.");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

        }

        //the credits that play at the end
        public static void Credits()
        {
            Console.WriteLine(@"
_____/\\\\\\\\\\________________/\\\\\\\\\_____/\\\\____________/\\\\_        
 ___/\\\///////\\\_____________/\\\\\\\\\\\\\__\/\\\\\\________/\\\\\\_       
  __\///______/\\\_____________/\\\/////////\\\_\/\\\//\\\____/\\\//\\\_      
   _________/\\\//_____________\/\\\_______\/\\\_\/\\\\///\\\/\\\/_\/\\\_     
    ________\////\\\____________\/\\\\\\\\\\\\\\\_\/\\\__\///\\\/___\/\\\_    
     ___________\//\\\___________\/\\\/////////\\\_\/\\\____\///_____\/\\\_   
      __/\\\______/\\\____________\/\\\_______\/\\\_\/\\\_____________\/\\\_  
       _\///\\\\\\\\\/_____________\/\\\_______\/\\\_\/\\\_____________\/\\\_ 
        ___\/////////_______________\///________\///__\///______________\///__");
            Thread.Sleep(5000);
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine(@"
 Assignment: Midterm Project - Adventure Game
 Title: 3AM
 Name: Ciarenn Hollis
 Date: 2 November 2021, Fall Semester 2021
");
            Console.WriteLine("  ");
            Console.ReadLine();
            Console.WriteLine(" Title Design: https://patorjk.com/software/taag/#p=display&f=Slant%20Relief&t=Type%20Something%20");
            Console.ReadLine();
            Console.WriteLine(" Flower Designs from: http://loveascii.com/flowers2.html");
            Console.ReadLine();
            Console.WriteLine(" Jar Design adapted from: https://asciiart.website/index.php?art=objects/bottles");
            Console.ReadLine();

        }


    }

    class ItsActions
    {
        //Variables
        static public bool GivenApproval = false;

        //It's Scenario
        static string ScenarioGoingToDoor = @"
 You approach the glowing door.
 It feels colder the closer you get.
 A sense of unease rises in you, 
 but the reason why you don't know.";

        //First step of reaching the win condition, becomes true when the player with the Non-player characters
        public static void Approve()
        {
            GivenApproval = true;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" The glow from the bathroom door grows stronger. \n It's light now elluminating the gas station.");
            Thread.Sleep(3000);

        }

        //Interacting with IT
        static public void TalkingToIT()
        {

            Console.WriteLine(ScenarioGoingToDoor);
            Thread.Sleep(2000);

            if (GivenApproval == true)
            {



                Console.WriteLine($"IT: {Game.PlayerName}, you have made friends and gained my approval.");
                Thread.Sleep(3000);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"IT: You may leave now. Good bye, {Game.PlayerName}.");
                Thread.Sleep(3000);
                Console.WriteLine(" Press [ENTER] ");
                Console.ReadLine();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;

                Game.Trapped = false;

            }
            else
            {
                Console.WriteLine($"IT: {Game.PlayerName}, you have not gained my approval.");
                Thread.Sleep(3000);
                Console.WriteLine("IT: Come back when you have.");
                Thread.Sleep(5000);
            }
        }
    }

    class JACKactions
    {

        //Variables
        private static int PlayGame;

        //Jack's Scenario
        public static string ScenarioJACK = @"
 You head over to the cashier's counter.
 The guy sitting behind it is distracted
 with the doodles he's drawing on his paper
 and doesn't notice you approaching.";

        //Interacting with JACK
        public static void JackInteraction()
        {


            Console.WriteLine(ScenarioJACK);
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("  ");
            Console.WriteLine("Jack: Oh. Hello.");
            Thread.Sleep(2000);
            Console.WriteLine("Jack: Didn't see you there.");



            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("  ");
            Console.WriteLine("A silence stretchs between the two of you. \nJack continues to doodle strange icons on the paper.");
            Thread.Sleep(6000);

            Console.Clear();
            Console.WriteLine("  ");
            Console.WriteLine("Jack: Hey, do you wanna play a game? \n 1)Yes 2)No");
            PlayGame = Convert.ToInt32(Console.ReadLine());


            if (PlayGame == 1)
            {
                Console.WriteLine("Life seeps back into Jack's face as he perks up and looks at you with an excited look in his eye. \nJack: Let's play ROCK, PAPER, SCISSORS!");
                Thread.Sleep(4000);
                RPSgame.JacksGame();
                Thread.Sleep(5000);
                Console.Clear();
                //attention brought to the glowing door.
                ItsActions.Approve();
                Thread.Sleep(5000);
            }
            else if (PlayGame == 2)
            {
                Console.WriteLine("Ah. Well, that's too bad.");
                Thread.Sleep(5000);

            }
            else
            {
                Console.WriteLine("Please enter 1 or 2");
                Console.WriteLine(" Press [ENTER] to continue");
                Console.ReadLine();
                JackInteraction();
            }

            
        }










    }


    class JOHNSactions
    {
        //John's Scenario
        static string ScenarioJOHN = @"
 You make your way to the back of the store.
 There's this man shuffling about gathering things together. 
 Once he notices you, he stops and turns to face you.";

        private static string choices = @"
 1) Ask what he is doing
 2) Ask about the glowing door
 3) Ask about the zucchinis
 4) Ask why the zucchinis
 5) Walk away";


        //Variables
        private static int Choice;

        
        //Interacting with JOHN
        public static void JohnInteraction()
        {
            Console.WriteLine(ScenarioJOHN);
            Thread.Sleep(3000);

            Console.WriteLine("  ");
            Console.WriteLine("JOHN: So, what's up?");
            Thread.Sleep(2000);
            Console.WriteLine(choices);
            Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    Console.WriteLine($"{Game.PlayerName}: What are you doing?");
                    Thread.Sleep(3000);
                    Console.WriteLine($"JOHN: Oh, me? I spilled my zucchinis everywhere. *laughs nervously* it's kinda hard to see them in the dark.");
                    Thread.Sleep(3000);
                    Console.WriteLine($" {Game.PlayerName}: 1) Yeah, it's real dark in here. 2) Ok.");
                    int _dialogue1_1 = Convert.ToInt32(Console.ReadLine());
                    if (_dialogue1_1 == 1)
                    {
                        Console.WriteLine($" {Game.PlayerName}: Yeah, it's real dark in here.");
                        Thread.Sleep(3000);
                        Console.Clear();
                        JohnInteraction2();
                    }
                    else if (_dialogue1_1 == 2)
                    {
                        Console.WriteLine($" {Game.PlayerName}: Ok.");
                        Thread.Sleep(3000);
                        Console.Clear();
                        JohnInteraction2();
                    }
                    else
                    {
                        Console.Clear();
                        JohnInteraction2();
                    }
                    Thread.Sleep(3000);
                    break;
                case 2:
                    Console.WriteLine($" {Game.PlayerName}: What's with the glowing door?");
                    Thread.Sleep(3000);
                    Console.WriteLine("JOHN: *leans in closer to you and speaks ominously*");
                    Thread.Sleep(2000);
                    Console.WriteLine("JOHN: There's something in there.");
                    Thread.Sleep(3000);

                    Console.WriteLine($" {Game.PlayerName}: 1) What's in there? 2) O-okay...");
                    int _dialogue2_1 = Convert.ToInt32(Console.ReadLine());
                    if (_dialogue2_1 == 1)
                    {
                        Console.WriteLine($" {Game.PlayerName}: What's in there?");
                        Thread.Sleep(3000);
                        Console.WriteLine("JOHN: *leans even closer and speaks quieter*");
                        Thread.Sleep(3000);
                        Console.WriteLine("JOHN: It's something bulbous and slimy, something round and moist with jagged edges, something slithering and twitching that stares with dark beady eyes.");
                        Thread.Sleep(6000);
                        Console.WriteLine(" ");
                        Console.WriteLine("JOHN: It comes every night without fail.");
                        Thread.Sleep(2000);
                        Console.WriteLine("JOHN: We can't leave until It does.");
                        Thread.Sleep(15000);
                        Console.Clear();
                        JohnInteraction2();

                    }
                    else if (_dialogue2_1 == 2)
                    {
                        Console.WriteLine($" {Game.PlayerName}: O-okay...");
                        Thread.Sleep(3000);
                        JohnInteraction2();
                    }
                    else
                    {
                        JohnInteraction2();
                    }
                    break;
                case 3:
                    Console.WriteLine($" {Game.PlayerName}: What's with the zucchinis?");
                    Thread.Sleep(3000);
                    Console.WriteLine("JOHN: It really seems to like them.");
                    Thread.Sleep(3000);


                    Console.WriteLine($" {Game.PlayerName}: 1) You feed It?? 2) Al-righty then...");
                    int _dialogue3_1 = Convert.ToInt32(Console.ReadLine());
                    if (_dialogue3_1 == 1)
                    {
                        Console.WriteLine($" {Game.PlayerName}: You feed It??");
                        Thread.Sleep(3000);
                        Console.WriteLine("JOHN: Yeah, why not?");
                        Thread.Sleep(3000);
                        Console.WriteLine("JOHN: Its unfeeling beady eyes seem happy when I do.");
                    }
                    else if (_dialogue3_1 == 2)
                    {
                        Console.WriteLine($" {Game.PlayerName}: Al-righty then...");
                        Thread.Sleep(3000);
                        Console.Clear();
                        JohnInteraction2();
                    }
                    else
                    {
                        JohnInteraction2();
                    }

                    break;
                case 4:
                    Console.WriteLine($" {Game.PlayerName}: Why feed It zucchinis?");
                    Thread.Sleep(3000);
                    Console.WriteLine("JOHN: I inherited my family's zucchini farm when they passed away.");
                    Thread.Sleep(3000);
                    Console.WriteLine("JOHN: *takes a pause*");
                    Thread.Sleep(3000);
                    Console.WriteLine("JOHN: *sniffles a bit* Why not share this surplus that I have?");
                    Thread.Sleep(3000);

                    Console.WriteLine($" {Game.PlayerName}: *nods in sympathy*");
                    Thread.Sleep(3000);
                    JohnInteraction2();

                    break;
                case 5:
                    //walks away.
                    Console.WriteLine($" {Game.PlayerName}: *walks away*");
                    Thread.Sleep(3000);
                    Game.MenuV2();
                    break;
            }

            //The secondary menu for interacting with JOHN
            void JohnInteraction2()
            {

                Thread.Sleep(3000);

                Console.WriteLine("JOHN: So, what's up?");
                Thread.Sleep(2000);
                Console.WriteLine(choices);
                Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        Console.WriteLine($"{ Game.PlayerName}: What are you doing?");
                        Thread.Sleep(3000);
                        Console.WriteLine($"JOHN: Oh, me? I spilled my zucchinis everywhere. *laughs nervously* it's kinda hard to see them in the dark.");
                        Thread.Sleep(3000);
                        Console.WriteLine($"{ Game.PlayerName}: 1) Yeah, it's real dark in here. 2) Ok.");
                        int _dialogue1_1 = Convert.ToInt32(Console.ReadLine());
                        if (_dialogue1_1 == 1)
                        {
                            Console.WriteLine($"{ Game.PlayerName}: Yeah, it's real dark in here.");
                            Thread.Sleep(3000);
                            Console.Clear();
                            JohnInteraction2();
                        }
                        else if (_dialogue1_1 == 2)
                        {
                            Console.WriteLine($"{ Game.PlayerName}: Ok.");
                            Thread.Sleep(3000);
                            Console.Clear();
                            JohnInteraction2();
                        }
                        else
                        {
                            Console.Clear();
                            JohnInteraction2();
                        }
                        Thread.Sleep(3000);
                        break;
                    case 2:
                        Console.WriteLine($"{ Game.PlayerName}: What's with the glowing door?");
                        Thread.Sleep(3000);
                        Console.WriteLine("JOHN: *leans in closer to you and speaks ominously*");
                        Thread.Sleep(2000);
                        Console.WriteLine("JOHN: There's something in there.");
                        Thread.Sleep(3000);

                        Console.WriteLine($"{ Game.PlayerName}: 1) What's in there? 2) O-okay...");
                        int _dialogue2_1 = Convert.ToInt32(Console.ReadLine());
                        if (_dialogue2_1 == 1)
                        {
                            Console.WriteLine($"{ Game.PlayerName}: What's in there?");
                            Thread.Sleep(3000);
                            Console.WriteLine("JOHN: *leans even closer and speaks quieter*");
                            Thread.Sleep(3000);
                            Console.WriteLine(@"It's something bulbous and slimy, something round and moist with jagged edges, something slithering and twitching that stares with dark beady eyes.");
                            Thread.Sleep(2000);
                            Console.WriteLine(" ");
                            Thread.Sleep(15000);
                            Console.Clear();
                            JohnInteraction2();

                        }
                        else if (_dialogue2_1 == 2)
                        {
                            Console.WriteLine($"{Game.PlayerName}: O-okay...");
                            Thread.Sleep(3000);
                            JohnInteraction2();
                        }
                        else
                        {
                            JohnInteraction2();
                        }
                        break;
                    case 3:
                        Console.WriteLine($"{Game.PlayerName}: What's with the zucchinis?");
                        Thread.Sleep(3000);
                        Console.WriteLine("JOHN: It really seems to like them.");
                        Thread.Sleep(3000);


                        Console.WriteLine($"{Game.PlayerName}: 1) You feed It?? 2) Al-righty then...");
                        int _dialogue3_1 = Convert.ToInt32(Console.ReadLine());
                        if (_dialogue3_1 == 1)
                        {
                            Console.WriteLine($"{Game.PlayerName}: You feed It??");
                            Thread.Sleep(3000);
                            Console.WriteLine("JOHN: Yeah, why not?");
                            Thread.Sleep(3000);
                            Console.WriteLine("Its unfeeling beady eyes seem happy when I do.");
                        }
                        else if (_dialogue3_1 == 2)
                        {
                            Console.WriteLine($"{Game.PlayerName}: Al-righty then...");
                            Thread.Sleep(3000);
                            Console.Clear();
                            JohnInteraction2();
                        }
                        else
                        {
                            JohnInteraction2();
                        }

                        break;
                    case 4:
                        Console.WriteLine($"{Game.PlayerName}: Why feed It zucchinis?");
                        Thread.Sleep(3000);
                        Console.WriteLine("JOHN: I inherited my family's zucchini farm when they passed away.");
                        Thread.Sleep(3000);
                        Console.WriteLine("JOHN: *takes a pause*");
                        Thread.Sleep(3000);
                        Console.WriteLine("JOHN: *sniffles a bit* Why not share this surplus that I have?");
                        Thread.Sleep(3000);

                        Console.WriteLine($"{Game.PlayerName}: *nods in sympathy*");
                        Thread.Sleep(3000);

                        break;
                    case 5:
                        //walks away.
                        Console.WriteLine($"{Game.PlayerName}: *walks away*");
                        Thread.Sleep(3000);
                        Game.MenuV2();
                        break;
                }

            }


        }
    }

    class JESSIESactions
    {
        //Variables
        private static int response;

        public static int JarCount = 0;

        //Scenario
        static string ScenarioJESSIE = @"
 You make your way through the aisles to the figure in the witch hat. 
 She moves slowly as she looks at the products on the shelf before her.
 Upon hearing you approach, she turns to face you.";


        //Interacting with JESSIE
        public static void JessieInteraction()
        {
            Console.WriteLine(ScenarioJESSIE);
            Thread.Sleep(3000);

            Console.WriteLine("Do want to make a good luck charm?");
            Console.WriteLine("1)Yes 2)No");
            response = Convert.ToInt32(Console.ReadLine());


            if (response == 1)
            {
                if (JarCount == 0)
                {
                    Console.WriteLine("Alright, dear.");
                    Thread.Sleep(2000);

                    //Gathering info for instatiation
                    Console.WriteLine("What kind of flower do want in it?");
                    Thread.Sleep(1000);
                    Console.WriteLine("1) Lavendar 2)Rose 3)Sunflower");
                    int FlowerInput = Convert.ToInt32(Console.ReadLine());
                    Thread.Sleep(3000);

                    Console.WriteLine("What type of stone do want in it?");
                    Thread.Sleep(1000);
                    Console.WriteLine("1) Rose Quartz 2)Amber 3)Emerald");
                    int StoneInput = Convert.ToInt32(Console.ReadLine());

                    Thread.Sleep(3000);

                    //Instantiation
                    Jar MyJar1 = new Jar(FlowerInput, StoneInput);
                    MyJar1.About();
                    MyJar1.Display();


                    //Jar count increases
                    JarCount = JarCount++;
                    Console.WriteLine(" Press ENTER to take your lucky charm.");
                    Console.ReadLine();

                    Console.Clear();

                }
                else if (JarCount == 1)
                {
                    Console.WriteLine("JESSIE: Alright, dear.");
                    Thread.Sleep(3000);

                    //Gathering info for instatiation
                    Console.WriteLine("JESSIE: What kind of flower do want in it?");
                    Thread.Sleep(1000);
                    Console.WriteLine(" 1) Lavendar 2)Rose 3)Sunflower");
                    int FlowerInput = Convert.ToInt32(Console.ReadLine());
                    Thread.Sleep(3000);

                    Console.WriteLine("JESSIE: What type of stone do want in it?");
                    Thread.Sleep(1000);
                    Console.WriteLine(" 1) Rose Quartz 2)Amber 3)Emerald");
                    int StoneInput = Convert.ToInt32(Console.ReadLine());

                    Thread.Sleep(3000);

                    //Instantiation
                    Jar MyJar2 = new Jar(FlowerInput, StoneInput);
                    MyJar2.About();
                    MyJar2.Display();


                    //Jar count increases
                    JarCount = JarCount++;
                    Console.WriteLine(" Press ENTER to take your lucky charm.");
                    Console.ReadLine();

                    Console.Clear();

                }
                else if (JarCount == 2)
                {
                    Console.WriteLine("JESSIE: Alright, dear.");
                    Thread.Sleep(3000);

                    //Gathering info for instatiation
                    Console.WriteLine("JESSIE: What kind of flower do want in it?");
                    Thread.Sleep(1000);
                    Console.WriteLine(" 1) Lavendar 2)Rose 3)Sunflower");
                    int FlowerInput = Convert.ToInt32(Console.ReadLine());
                    Thread.Sleep(3000);

                    Console.WriteLine("JESSIE: What type of stone do want in it?");
                    Thread.Sleep(1000);
                    Console.WriteLine(" 1) Rose Quartz 2)Amber 3)Emerald");
                    int StoneInput = Convert.ToInt32(Console.ReadLine());

                    Thread.Sleep(3000);

                    //Instantiation
                    Jar MyJar3 = new Jar(FlowerInput, StoneInput);
                    MyJar3.About();
                    MyJar3.Display();


                    //Jar count increases
                    JarCount = JarCount++;
                    Console.WriteLine(" Press ENTER to take your lucky charm.");
                    Console.ReadLine();

                    Console.Clear();

                }
                else if (JarCount == 3)
                {
                    Console.WriteLine("JESSIE: Alright, dear.");
                    Thread.Sleep(2000);

                    //Gathering info for instatiation
                    Console.WriteLine("JESSIE: What kind of flower do want in it?");
                    Thread.Sleep(1000);
                    Console.WriteLine(" 1) Lavendar 2)Rose 3)Sunflower");
                    int FlowerInput = Convert.ToInt32(Console.ReadLine());
                    Thread.Sleep(3000);

                    Console.WriteLine("JESSIE: What type of stone do want in it?");
                    Thread.Sleep(1000);
                    Console.WriteLine(" 1) Rose Quartz 2)Amber 3)Emerald");
                    int StoneInput = Convert.ToInt32(Console.ReadLine());

                    Thread.Sleep(3000);

                    //Instantiation
                    Jar MyJar4 = new Jar(FlowerInput, StoneInput);
                    MyJar4.About();
                    MyJar4.Display();


                    //Jar count increases
                    JarCount = JarCount++;
                    Console.WriteLine(" Press ENTER to take your lucky charm.");
                    Console.ReadLine();

                    Console.Clear();

                }
                else if (JarCount == 4)
                {
                    Console.WriteLine("JESSIE: Alright, dear.");
                    Thread.Sleep(3000);

                    //Gathering info for instatiation
                    Console.WriteLine("JESSIE: What kind of flower do want in it?");
                    Thread.Sleep(1000);
                    Console.WriteLine(" 1) Lavendar 2)Rose 3)Sunflower");
                    int FlowerInput = Convert.ToInt32(Console.ReadLine());
                    Thread.Sleep(3000);

                    Console.WriteLine("JESSIE: What type of stone do want in it?");
                    Thread.Sleep(1000);
                    Console.WriteLine(" 1) Rose Quartz 2)Amber 3)Emerald");
                    int StoneInput = Convert.ToInt32(Console.ReadLine());

                    Thread.Sleep(3000);

                    //Instantiation
                    Jar MyJar5 = new Jar(FlowerInput, StoneInput);
                    MyJar5.About();
                    MyJar5.Display();


                    //Jar count increases
                    JarCount = JarCount++;
                    Console.WriteLine(" Press ENTER to take your lucky charm.");
                    Console.ReadLine();

                    Console.Clear();

                }
                else if (JarCount == 5)
                {
                    Console.WriteLine("JESSIE: I'm sorry, dear, you can only have so much luck.");
                }

                //attention brought to the glowing door.
                ItsActions.Approve();

            }
            else if (response == 2)
            {
                Console.WriteLine("JESSIE: Have a good night then, dear.");
                Thread.Sleep(5000);
            }




        }

    }


    class RPSgame
    {
        //Variables
        private static int RPSchoice;

        //The Rock, Paper, Scissors game
        public static void JacksGame()
        {
            string[] RPS = { "ROCK", "PAPER", "SCISSORS" };

            var rand = new Random();

            int JacksChoice = rand.Next(RPS.Length);

            Console.WriteLine(" 0)ROCK, 1)PAPER, or 2)Scissors?");
            RPSchoice = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(" ROCK...");
            Thread.Sleep(1500);
            Console.WriteLine(" PAPER...");
            Thread.Sleep(1500);
            Console.WriteLine(" SCISSORS...");
            Thread.Sleep(1500);
            Console.WriteLine(" SHOOT!");
            Thread.Sleep(1500);

            if (JacksChoice == RPSchoice)
            {

                Console.WriteLine(" It's a Draw!");
                Thread.Sleep(3000);
                Console.WriteLine($" You have {RPS[RPSchoice]} and Jack had {RPS[JacksChoice]}.");
                Console.ReadLine();
            }
            else if (JacksChoice == 0 && RPSchoice == 1)
            {
                Console.WriteLine(" You Win!");
                Thread.Sleep(3000);
                Console.WriteLine($" You have {RPS[RPSchoice]} and Jack had {RPS[JacksChoice]}.");
                Console.ReadLine();

            }
            else if (JacksChoice == 1 && RPSchoice == 2)
            {
                Console.WriteLine(" You Win!");
                Thread.Sleep(3000);
                Console.WriteLine($" You have {RPS[RPSchoice]} and Jack had {RPS[JacksChoice]}.");
                Console.ReadLine();
            }
            else if (JacksChoice == 2 && RPSchoice == 0)
            {
                Console.WriteLine(" You Win!");
                Thread.Sleep(3000);
                Console.WriteLine($" You have {RPS[RPSchoice]} and Jack had {RPS[JacksChoice]}.");
                Console.ReadLine();
            }
            else if (RPSchoice == 0 && JacksChoice == 1)
            {
                Console.WriteLine(" You Lose!");
                Thread.Sleep(3000);
                Console.WriteLine($" You have {RPS[RPSchoice]} and Jack had {RPS[JacksChoice]}.");
                Console.ReadLine();
            }
            else if (RPSchoice == 1 && JacksChoice == 2)
            {
                Console.WriteLine(" You Lose!");
                Thread.Sleep(3000);
                Console.WriteLine($" You have {RPS[RPSchoice]} and Jack had {RPS[JacksChoice]}.");
                Console.ReadLine();
            }
            else if (RPSchoice == 2 && JacksChoice == 0)
            {
                Console.WriteLine(" You Lose!");
                Thread.Sleep(3000);
                Console.WriteLine($" You have {RPS[RPSchoice]} and Jack had {RPS[JacksChoice]}.");
                Console.ReadLine();
            }


         
        }
    }


    class Jar
    {

        //Variables
        int FlowerType; //determines art
        int Stone; //color

        string flowers;
        string stones;


        //Jar constructor
        public Jar(int _flowerType, int _stone)
        {
            
            this.FlowerType = _flowerType;
            this.Stone = _stone;

            //flower
            if (_flowerType == 1)
            {
                flowers = "Lavendar";
            }
            else if (_flowerType == 2)
            {
                flowers = "Rose";
            }
            else if (_flowerType == 3)
            {
                flowers = "Sunflower";
            }

            //stones
            if (_stone == 1)
            {
                stones = "Rose Quartz";
            }
            else if (_stone == 2)
            {
                stones = "Amber";
            }
            else if (_stone == 3)
            {
                flowers = "Emerald";
            }

        }

        //Jar describes itself
        public void About()
        {
            Console.WriteLine($"This is a jar filled with {flowers} and {stones}s");
        }

        //Prints the jar
        public void Display()
        {
            Console.Clear();
            Console.WriteLine($"You examine your lucky charm.");

            //stones deciding color
            if (this.Stone == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;

                if (this.FlowerType == 1)
                {
                    Console.WriteLine(LavendarJarArt);
                    Console.ForegroundColor = ConsoleColor.Magenta; //changes color back to match the game
                }
                else if (this.FlowerType == 2)
                {
                    Console.WriteLine(RoseJarArt);
                    Console.ForegroundColor = ConsoleColor.Magenta; //changes color back to match the game
                }
                else if (this.FlowerType == 3)
                {
                    Console.WriteLine(SunflowerJarArt);
                    Console.ForegroundColor = ConsoleColor.Magenta; //changes color back to match the game
                }
            }
            else if (this.Stone == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                if (this.FlowerType == 1)
                {
                    Console.WriteLine(LavendarJarArt);
                    Console.ForegroundColor = ConsoleColor.Magenta; //changes color back to match the game

                }
                else if (this.FlowerType == 2)
                {
                    Console.WriteLine(RoseJarArt);
                    Console.ForegroundColor = ConsoleColor.Magenta; //changes color back to match the game
                }
                else if (this.FlowerType == 3)
                {
                    Console.WriteLine(SunflowerJarArt);
                    Console.ForegroundColor = ConsoleColor.Magenta; //changes color back to match the game
                }
            }
            else if (this.Stone == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                if (this.FlowerType == 1)
                {
                    Console.WriteLine(LavendarJarArt);
                    Console.ForegroundColor = ConsoleColor.Magenta; //changes color back to match the game
                }
                else if (this.FlowerType == 2)
                {
                    Console.WriteLine(RoseJarArt);
                    Console.ForegroundColor = ConsoleColor.Magenta; //changes color back to match the game
                }
                else if (this.FlowerType == 3)
                {
                    Console.WriteLine(SunflowerJarArt);
                    Console.ForegroundColor = ConsoleColor.Magenta; //changes color back to match the game
                }
            }

        }

        //Jar Art
        public string LavendarJarArt = @"
      _________
     `._______,'
      (___L___)
      <     * >
       ) @   (
      / @|@ * \
     /  @|@    \
    / * @|@   * \
   :     | _     :
   | * _ |(/    *|
   :   \)|  *    ;
    \  * |      /
     `.___*___.'   ";

        public string RoseJarArt = @"
      _________
     `._______,'
      (___R___)
      <  +    >
       ).    (
      /    +  \
     / (')     \
    /+ \)/     +\
   :      + (')  :
   | +      \)/  |
   :  (')  +     ;
    \ \)/     + /
     `.___+___.'   ";

        public string SunflowerJarArt = @"
      _________
     `._______,'
      (___S___)
      <    `  >
       )`    (
      /  .*.  \
     /   *** ` \
    /  `  V     \
   :    (\|  `   :
   |`     |/)  ` |
   :   `  |      ;
    \     `    `/
     `.__`____.'  ";
    }

}
