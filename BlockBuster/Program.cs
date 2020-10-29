using System;
using System.Collections.Generic;
using System.Threading;

namespace BlockBuster
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockBuster bb = new BlockBuster();
           
            while (true)
            {
                MyLibs.ConsoleLibrary.DrawTitle("Welcome to GC Blockbuster!");

                Movie userSelection = bb.CheckOut();

                userSelection.PrintInfo();

                bool watchMovie = MyLibs.UserInputLibrary.GetYesOrNoInput("Great choice! You wanna like, hang out and watch that here?");
                
                if (watchMovie)
                {
                    bool playWholeMovie = MyLibs.UserInputLibrary.GetYesOrNoInput("Are we watching the whole thing?");

                    if (playWholeMovie)
                    {
                        Console.Clear();
                        userSelection.PlayWholeMovie();
                    }
                    else
                    {
                        Console.Clear();
                        userSelection.Play();
                    }
                }
                else 
                {
                    Console.WriteLine("Fine, I guess. Enjoy your movie at home or whatever, nerd");
                    Thread.Sleep(2000);
                    break;
                }
            }
        }
    }
}
