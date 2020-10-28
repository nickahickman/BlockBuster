using System;
using System.Collections.Generic;

namespace BlockBuster
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockBuster bb = new BlockBuster();
            //use thread.sleep to change scenes on vhs
            while (true)
            {
                MyLibs.ConsoleLibrary.DrawTitle("Welcome to GC Blockbuster!");

                Movie userSelection = bb.CheckOut();

                userSelection.PrintInfo();

                bool watchMovie = MyLibs.UserInputLibrary.GetYesOrNoInput("Great choice! You wanna like, hang out and watch that here?");

                if (watchMovie)
                {

                }
                else 
                { 
                
                }
            }
        }
    }
}
