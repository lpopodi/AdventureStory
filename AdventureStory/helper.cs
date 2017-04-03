using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureStory
{
    public class Helper
    {
        static Random rnd = new Random();
        public void addHelper()
        {
            List<string> helpers = new List<string>(new string[] { "Fairy Godmother", "Grandmother Willow", "Trolls", "Flora, Fauna, and Meriwether", "Tinker Bell", "Genie" });
            int chosenHelper = rnd.Next(helpers.Count);
            Console.WriteLine(helpers[chosenHelper] + " has come to assist you in your journey");
            
        }
        

    }
}
