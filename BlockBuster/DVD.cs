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

            PrintScenes();
            int selectedScene = MyLibs.UserInputLibrary.GetMenuSelection("Which scene do you want to watch?", Scenes);

            Console.Clear();

            for (int i = selectedScene; i < Scenes.Count; i++)
            {
                Console.WriteLine($"{Scenes[i]}");
                Thread.Sleep(2000);
            }

            Console.Clear();
        }
    }
}
