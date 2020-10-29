using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBuster
{
    class BlockBuster
    {
        public List<Movie> Movies = new List<Movie>()
        {
            new DVD("Star Wars: Episode V - The Empire Strikes Back", Genre.Action, 124, new List<string>()
            {
                "Space Letters Scrolling",
                "It's Cold, Sleep in the Tantaun",
                "Obi-Wan's Ghost Gives Instructions",
                "Following Ghost Instructions",
                "Bounty Hunters ZOMG",
                "The Empire Closes In",
                "The Rebel Fleet Wins"
            }),
            new DVD("The Matrix", Genre.Action, 136, new List<string>()
            {
                "Trinity Freeze Frame!",
                "They're Coming to Get You Neo",
                "Morpheus' Got Drugs",
                "Download Kung Fu Into Your Brain",
                "AI Doesn't Like Humans",
                "Lobby Shooting Spree",
                "Neo Can Fly Now!"
            }),
            new DVD("Alien", Genre.Horror, 117, new List<string>()
            {
                "Auto Pilot",
                "Answering the Call",
                "Facehugger",
                "Stick Together",
                "Into the Airducts",
                "Escape Plan",
                "Survivors"
            }),
            new VHS("Independence Day", Genre.Action, 145, new List<string>()
            {
                "Aliens hover ominously",
                "90's White House Fantasy",
                "Aliens Still Just Waiting",
                "Punching Aliens",
                "Area 51 OMG!!",
                "Jeff Goldbloom Hacks Aliens",
                "Aliens Should Have Used Antivirus, Humans Win Again. Confetti Drops"
            }, 0),
            new VHS("The Evil Dead", Genre.Horror, 85, new List<string>()
            {
                "The Cabin",
                "Book of the Dead",
                "Possession",
                "Unholy Laughter",
                "Taste the Blood of Ash",
                "Last Stand",
                "Dawn of the Dead"
            }, 4),
            new VHS("Halloween", Genre.Horror, 91, new List<string>()
            {
                "All Hallows Eve, 1963",
                "Haunted House",
                "The Bogeyman",
                "Masquerade",
                "Decorations",
                "'It Was the Bogeyman'"
            }, 0),

    };

        public void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"{i + 1} {Movies[i].Title} ({Movies[i].GetType().Name})");
            }
            Console.WriteLine();
        }

        public Movie CheckOut()
        {
            PrintMovies();
            int selection = MyLibs.UserInputLibrary.GetMenuSelection("Which of our fine films would you like to see today? ", Movies);
            
            return Movies[selection];

        }
    }
}
