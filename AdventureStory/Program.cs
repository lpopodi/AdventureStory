using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureStory
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter setPlayer = new PlayerCharacter();
            setPlayer.GetAdenturer();

            story setStory = new story();
            setStory.StartQuest();

            setStory.BeforeVillan();

            setStory.BeforeSidekick();

        }
    }
}
