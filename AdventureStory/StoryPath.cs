using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureStory
{
    public class story
    {
        
        string beginQuest;
        string revealVillan;
        string revealSidekick;

        public void StartQuest()
        {
            Console.WriteLine("Welcome to Your Quest to Find the Golden Mickey");
            Console.WriteLine("On your quest you will choose a magical land, you will get a magical helper, a sidekick (could be good, but could also be sidekick on the dard side) and you will encounter an villan.  In the end you will either be defeated by the villan, or your helpers will get you to the Golden Mickey!");
            Console.WriteLine("Are you ready to begin?");
            Console.WriteLine("Enter Yes / No");
            beginQuest = Console.ReadLine();
            if (beginQuest.ToLower() == "yes")
            {
                Land setLand = new Land();
                setLand.chooseLand();
            }
            else
            {
                Console.WriteLine("You have chosen not to play, restarting the app ..");
                StartQuest();
            }
            Console.ReadLine();
        }

        public void BeforeVillan()
        {
            Console.WriteLine("As you travel through this journey, you will face an evil villan trying to get to the Golden Mickey.  Type Yes to see who your challenger is.");
            revealVillan = Console.ReadLine();
                    if (revealVillan.ToLower() == "yes")
                    {
                Villan setVillan = new Villan();
                setVillan.faceVillan();
            }
                    else
                    {
                Console.WriteLine("You may not want to face the villan but it is a part of your journey that you must complete.");
                Villan setVillan = new Villan();
                setVillan.faceVillan();
            }
        }

        public void BeforeSidekick()
        {
            Console.WriteLine("Now that you are prepared to face the Villan, a sidekick may be a great asset, but it can also be an asset to the other side?  Do you dare to see who is coming to help?");
            revealSidekick = Console.ReadLine();
            if (revealSidekick.ToLower() == "yes")
            {
                sidekick setSidekick = new sidekick();
                setSidekick.addSidekick();
            }
            else
            {
                Console.WriteLine("Chance has determined a sidekick is on the way anyway.");
                sidekick setSidekick = new sidekick();
                setSidekick.addSidekick();
            }
        }

    }
}

