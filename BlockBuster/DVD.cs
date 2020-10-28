using System;
using System.Collections.Generic;
using System.Text;

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
            throw new NotImplementedException();
        }
    }
}
