using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBuster
{
    abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int Runtime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string Title, Enum Genre, int Runtime, List<string> Scenes)
        { 
            this.Title = Title;
            this.Category = (Genre)Genre;
            this.Runtime = Runtime;
            this.Scenes = Scenes;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Runtime: {Runtime}\n");
        }

        public void PrintScenes()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                string scene = Scenes[i];
                Console.WriteLine($"{i+1}: {scene}");
            }
        }

        public abstract void Play();
        public abstract void PlayWholeMovie();
    }
}
