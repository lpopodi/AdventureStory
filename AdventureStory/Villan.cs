using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureStory
{
    public class Villan
    {
        static Random rnd = new Random();
        public void faceVillan()
        {
            List<string> villans = new List<string>(new string[] { "Gaston", "Captain Hook", "Jafar", "Queen of Hearts", "Maleficent", "Ursula", "Cruela De Vil", "The Evil Queen", "Lady Tremain" });
            int chosenVillan = rnd.Next(villans.Count);
            Console.WriteLine("Prepare to face " + villans[chosenVillan]);
            
        }
    }
}
