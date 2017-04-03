using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureStory
{

    public class sidekick
    {
        static Random rnd = new Random();

        public void addSidekick()
        {
            List<string> sidekicks = new List<string>(new string[] { "Mater", "Little John", "Olaf", "Sebastian", "Abu and Magic Carpet", "Lefou", "Iago", "Diablo", "Mr. Smee" });
            int chosenSidekick = rnd.Next(sidekicks.Count);
            string sidekickFate = sidekicks[chosenSidekick];

            switch (sidekickFate)
            {
                case "Lefou":
                    Console.WriteLine(sidekickFate + " from the dark side has come to help defeat you.  You have been defeated, game over");
                    break;
                case "Iago":
                    Console.WriteLine(sidekickFate + " from the dark side has come to help defeat you.  You have been defeated, game over");
                    break;
                case "Diablo":
                    Console.WriteLine(sidekickFate + " from the dark side has come to help defeat you.  You have been defeated, game over");
                    break;
                case "Mr. Smee":
                    Console.WriteLine(sidekickFate + " from the dark side has come to help defeat you.  You have been defeated, game over");
                    break;
                case "Abu and Magic Carpet":
                    Console.WriteLine(sidekickFate + " have come to assist you in your journey.  Since you have 2 great pals on your side, you were able to successfully defeat the villan on your journey and recover the Golden Mickey");
                    break;
                case "Olaf":
                    Console.WriteLine(sidekickFate + " have come to assist you in your journey.  Since you have 2 great pals on your side, you were able to successfully defeat the villan on your journey and recover the Golden Mickey");
                    break;
                case "Sebastian":
                    Console.WriteLine(sidekickFate + " have come to assist you in your journey.  Since you have 2 great pals on your side, you were able to successfully defeat the villan on your journey and recover the Golden Mickey");
                    break;
                case "Little John":
                    Console.WriteLine(sidekickFate + " have come to assist you in your journey.  Since you have 2 great pals on your side, you were able to successfully defeat the villan on your journey and recover the Golden Mickey");
                    break;
                case "Mater":
                    Console.WriteLine(sidekickFate + " have come to assist you in your journey.  Since you have 2 great pals on your side, you were able to successfully defeat the villan on your journey and recover the Golden Mickey");
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    break;
            }
            Console.ReadLine();
        }



    }
}
