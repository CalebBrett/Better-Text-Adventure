using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpicTextAdventure
{
    class Program
    {
        public static String name;
        public static String World; 
        public static String Quest;
        public static String yesno;
        public static String inventory;
        public static Array item;
        public static int MaxHealth = 20;
        public static int Health = 20;
        public static int Money = 20;
       
        static void Main(string[] args)
        {
            
            Console.WriteLine("What do you think this place is called?");
            World = Console.ReadLine();
            if(World == ("skip"))
            {
                Intro();
            }
            Console.WriteLine("Welcome to " + World);
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", Are you redy for your adventure through out " + World + ".");
            Console.ReadLine();
            Console.WriteLine("First, in this game there are commands you can use by typing keywords.");
            Console.ReadLine();
            Console.WriteLine("The first command is the 'Stats' command it will tell you things like how much  health or money you have. Try it.");
            if (Console.ReadLine() == ("Stats") || Console.ReadLine() == ("stats"))
            {
                Console.WriteLine("Health = " + Health + "/" + MaxHealth + " Gold = " + Money);
            }
            else
            {
                Console.WriteLine("Type Stats.");
                if (Console.ReadLine() == ("Stats") || Console.ReadLine() == ("stats"))
                {
                    Console.WriteLine("Health =" + Health + "/" + MaxHealth + " Gold =" + Money);
                }
            }
            Console.ReadLine();
            Console.WriteLine("The second is the 'Help' command it will give you a list of all the commands and an explinaton of what they do. Try it.");
            if (Console.ReadLine() == ("Help") || Console.ReadLine() == ("help"))
            {
                Console.WriteLine("Stats: Displays things like your money and health");
            }
            else
            {
                Console.WriteLine("Type Help.");
                if (Console.ReadLine() == ("Help") || Console.ReadLine() == ("help"))
                {
                    Console.ReadLine();
                    Console.WriteLine("Help: Shows a list of the commands and there meanings.");
                    Console.WriteLine("Stats: Displays things like your money and health.");
                    Console.WriteLine("Inv: (inventory) list all of you items.");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
            Intro();
        }
        public static void Intro() 
        {
            Console.Clear();
            Console.WriteLine("Now let's get started.");
            read();
            Console.WriteLine("You wake up lying aganst a tree. As you sit there you try to remember what you were doing.");
            read();
            Console.WriteLine("You were leaving your village and set out looking for the, what was it again?");
            Console.WriteLine("You remeber it was one of these: Crystal Cave, ____,____,______");
            Quest = Console.ReadLine();
            if (Quest != ("crystal cave"))
            {
                Console.WriteLine("That wasnt it.");
            }
            else
            {
                Console.WriteLine("Oh ya thats it the quest for " + Quest + ".");
                Console.ReadLine();
                if (Quest == ("crystal cave"))
                {
                    Quest1();
                }
            }
        }
        public static void Quest1() 
        {
            Console.WriteLine("Ok, you were headed for the wizzad who lives at the edge of the forest, to buy somethings to help on your adventure.");
            Console.WriteLine("You get up and start heading for the wizard.");
            read();
            Console.WriteLine("As you walk along the path you see something shiny sparkle to the left of you.");
            Console.WriteLine("Do you go and look at it?");
            Console.WriteLine("Yes or No");
            yesno = Console.ReadLine();
            if (yesno == ("yes"))
            {
                Console.WriteLine("You walk over and it looks like a small dagger.");
                read();
                Console.WriteLine("Do you whant to pick it up?");
                yesno = Console.ReadLine();
                if (yesno != ("yes") || yesno != ("no"))
                {
                    Console.WriteLine("That isnt an answer");
                    yesno = Console.ReadLine();
                }
                if (yesno == ("yes"))
                {
                    Console.WriteLine("You pick up the dagger.");
                    inventory = inventory + item;
                    read();
                }
            }
            else if (yesno == "no")
            {
                Console.WriteLine("Thats to bad it might have been important.");
            }
            else 
            {
                
            }
        }
        public static void read()
        {
            if (Console.ReadLine() == ("inv")) 
            {
                Console.WriteLine("You have ");
            }
            else if (Console.ReadLine() == ("stats"))
            {
                Console.WriteLine("Health = " + Health + "/" + MaxHealth + " Gold = " + Money);
            }
            else if (Console.ReadLine() == ("help"))
            {
                Console.WriteLine("Stats: Displays things like your money and health.");
                Console.WriteLine("Inv: (inventory) list all of you items.");
            }
            else 
            {
                Console.ReadLine();
            }
        }                                                                      
    }
}
