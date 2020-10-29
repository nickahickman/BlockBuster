using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BlockBuster
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(string Title, Enum Genre, int Runtime, List<string> Scenes, int CurrentTime) 
            :base(Title, Genre, Runtime, Scenes)
        {
            this.CurrentTime = CurrentTime;
        }

        public override void Play()
        {
            Console.Clear();

            while (CurrentTime < Scenes.Count)
            {
                Console.WriteLine(Scenes[CurrentTime]);
                CurrentTime++;
                Thread.Sleep(3000);
                Console.Clear();
            }

            Thread.Sleep(3000);
            Console.WriteLine("You're still here?");
            Thread.Sleep(2000);
            Console.WriteLine("It's over, go home.");
            Thread.Sleep(1500);
            Console.WriteLine("Go!");
            Thread.Sleep(1500);

            Console.Clear();
        }

        public override void PlayWholeMovie()
        {
            if (CurrentTime > 0)
            {
                Console.WriteLine("Ugh, last person didn't rewind this. Just a sec.");
                Thread.Sleep(1000);
                Console.WriteLine("Rewinding...");
                Thread.Sleep(4000);
                Rewind();
                Play();
            }
            else 
            {
                Play();
            }
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
