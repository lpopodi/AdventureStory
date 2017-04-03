using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureStory
{
    public class PlayerCharacter
    {
        //variables
        string name;

        public void GetAdenturer()
        {
            Console.WriteLine("Enter your Name");
            name = Console.ReadLine();
        }

       
    }
}
