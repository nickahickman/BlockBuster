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
                "Space Words Slowly Pass",
                "It's Cold, Let's Sleep in the Tantaun",
                "Ghost Gives Instructions",
                "Luke Follows Ghost Instructions",
                "Bounty Hunters ZOMG",
                "The Empire Closes In",
                "Rebels Achieve Glorious Victory"
            }),
            new DVD("The Matrix", Genre.Action, 136, new List<string>()
            {
                "Trinity Freeze Frame!",
                "They're Coming to Get You Neo",
                "Morpheus' Got Drugs",
                "Download Kung Fu Into Your Brain",
                "AI Doesn't Like Humans",
                "Shooty Shooty Bang Bang",
                "Neo Can Fly Now!"
            }),
            new DVD("Alien", Genre.Horror, 117, new List<string>()
            {
                "Nostromo Drives While Everyone Sleeps. Neat.",
                "That Moon Pinged Us. We Should Check it Out, This Will Only Take a Second",
                "Facehugger Does the Thing",
                "Stick Together. Finally Some Sense in This Type of Movie",
                "Use the Vents",
                "Alien Grappling Hook Burning Chaos",
                "Napping with Kitty"
            }),
            new VHS("Independence Day", Genre.Action, 145, new List<string>()
            {
                "Aliens hover ominously",
                "90's White House Fantasy",
                "Aliens Still Just Waiting",
                "Punching Aliens",
                "Area 51 OMG!!",
                "Jeff Goldbloom Hacks Aliens Because They Don't Have Norton",
                "Humans Win Again. Confetti Drops"
            }, 2),
            new VHS("The Evil Dead", Genre.Horror, 85, new List<string>()
            {
                "Let's Go Camping",
                "You Suck at Drawing, Let the Demon Try",
                "Cellar Door Opened Itself, Let's Investigate",
                "8 Track Demon Summoning",
                "Cheryl Has a Tantrum and Gets A Time Out",
                "Book Burning Accomplishes Something for Once",
                "Ash is Safe Now. Time to Walk Home"
            }, 1),
            new VHS("Halloween", Genre.Horror, 91, new List<string>()
            {
                "Halloween Murder Clown Starts Young",
                "Kids Say the Darndest Things",
                "Bad Guy Stalks",
                "Heavy Breathing Phone Call. Probs Just a Prank",
                "Masked Psycho Ruins Teenage Halloween",
                "Bad Guy Gets Shot. Won't Be Seeing Him Again.",
                "Where Did He Go?!?!?"
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
