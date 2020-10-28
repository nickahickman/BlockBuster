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
                "The Phantom Menace",
                "Ice Planet Hoth",
                "Obi-Wan's Instructions",
                "Leaving for Dagobah",
                "Bounty Hunters",
                "The Empire Closes In",
                "The Rebel Fleet"
            }),
            new DVD("The Matrix", Genre.Action, 136, new List<string>()
            {
                "Trinity In a Jam",
                "They're Coming For You",
                "Morpheus' Proposal",
                "Training Begins",
                "Virus to be Cured",
                "Lobby Shooting Spree",
                "He Is the One"
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
                "Contact",
                "At the White House",
                "Countdown to Extinction",
                "Welcome to Earth",
                "Area 51",
                "Execute 'Jolly Roger'",
                "Victory"
            }, 14),
            new VHS("The Evil Dead", Genre.Horror, 85, new List<string>()
            {
                "The Cabin",
                "Book of the Dead",
                "Possession",
                "Unholy Laughter",
                "Taste the Blood of Ash",
                "Last Stand",
                "Dawn of the Dead"
            }, 85),
            new VHS("Halloween", Genre.Horror, 91, new List<string>()
            {
                "All Hallows Eve, 1963",
                "Haunted House",
                "The Bogeyman",
                "Masquerade",
                "Decorations",
                "'It Was the Bogeyman'"
            }, 2),

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
