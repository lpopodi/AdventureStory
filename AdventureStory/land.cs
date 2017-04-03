using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureStory
{
    public class Land
    {
        string revealHelper;
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            for (int i = 0; i < Console.WindowWidth; i++)
                Console.Write(" ");
            Console.SetCursorPosition(0, currentLineCursor);
        }
        public void chooseLand()
        {
            Console.WriteLine("Choose a land from the following List, enter number of choice");
            Console.WriteLine("A - Arendelle");
            Console.WriteLine("B - Neverland");
            Console.WriteLine("C - Nottingham");
            Console.WriteLine("D - Jamestown");
            char chosenLand = Convert.ToChar(Console.ReadKey().KeyChar.ToString().ToUpper());
            switch (chosenLand)
            {
                case 'A':
                    ClearCurrentConsoleLine();
                    Console.WriteLine("You are now in Arendelle .. welcome to winter!");
                    Console.WriteLine("As you discover Arendelle, you may need some help along your way, Would you like to reveal who has come to help you on your journey?");
                    revealHelper = Console.ReadLine();
                    if (revealHelper.ToLower() == "yes")
                    {
                        Helper setHelper = new Helper();
                        setHelper.addHelper();
                    }
                    else
                    {
                        Console.WriteLine("You may have said no, but I'm going to show you anyway");
                        Helper setHelper = new Helper();
                        setHelper.addHelper();
                    }
                    break;
                case 'B':
                    ClearCurrentConsoleLine();
                    Console.WriteLine("You are now in Neverland .. feel free to be a kid again!");
                    Console.WriteLine("As you discover Neverland, you may need some help along your way, Would you like to reveal who has come to help you on your journey?");
                    revealHelper = Console.ReadLine();
                    if (revealHelper.ToLower() == "yes")
                    {
                        Helper setHelper = new Helper();
                        setHelper.addHelper();
                    }
                    else
                    {
                        Console.WriteLine("You may have said no, but I'm going to show you anyway");
                        Helper setHelper = new Helper();
                        setHelper.addHelper();
                    }
                    break;
                case 'C':
                    ClearCurrentConsoleLine();
                    Console.WriteLine("You are now in Nottingham .. watch out for that sheriff!");
                    Console.WriteLine("As you discover Nottingham, you may need some help along your way, Would you like to reveal who has come to help you on your journey?");
                    revealHelper = Console.ReadLine();
                    if (revealHelper.ToLower() == "yes")
                    {
                        Helper setHelper = new Helper();
                        setHelper.addHelper();
                    }
                    else
                    {
                        Console.WriteLine("You may have said no, but I'm going to show you anyway");
                        Helper setHelper = new Helper();
                        setHelper.addHelper();
                    }
                    break;
                case 'D':
                    ClearCurrentConsoleLine();
                    Console.WriteLine("You are now in Jamestown .. as declared by the English, the Indians would beg to differ!");
                    Console.WriteLine("As you discover Jamestown, you may need some help along your way, Would you like to reveal who has come to help you on your journey?");
                    revealHelper = Console.ReadLine();
                    if (revealHelper.ToLower() == "yes")
                    {
                        Helper setHelper = new Helper();
                        setHelper.addHelper();
                    }
                    else
                    {
                        Console.WriteLine("You may have said no, but I'm going to show you anyway");
                        Helper setHelper = new Helper();
                        setHelper.addHelper();
                    }
                    break;
                default:
                    ClearCurrentConsoleLine();
                    Console.WriteLine("You have not chosen a valid option, please try again.");
                    chooseLand();
                    break;

            }

   

        }
       
    }
}
