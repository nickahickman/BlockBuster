using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BlockBuster
{
    class DVD : Movie
    {
        public DVD(string Title, Enum Genre, int Runtime, List<string> Scenes)
            : base(Title, Genre, Runtime, Scenes)
        { 
        
        }
        public override void Play()
        {
            Console.Clear();

            while (true)
            {
                PrintScenes();
                int selectedScene = MyLibs.UserInputLibrary.GetMenuSelection("Which scene do you want to watch? ", Scenes);

                Console.Clear();

                Console.Clear();
                Console.WriteLine($"{Scenes[selectedScene]}");
                Thread.Sleep(3000);
                Console.Clear();

                if (!MyLibs.UserInputLibrary.GetYesOrNoInput("Watch Another Scene?"))
                {
                    break;
                }
                Console.Clear();
            }
           
            Console.Clear();
        }

        public override void PlayWholeMovie()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.Clear();
                Console.WriteLine($"{Scenes[i]}");
                Thread.Sleep(3000);
                Console.Clear();
            }
        }
    }
}
