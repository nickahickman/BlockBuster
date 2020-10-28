using System;
using System.Collections.Generic;
using System.Text;

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
            
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
