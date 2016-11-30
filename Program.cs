using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static Game myGame = new Game();
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Road Race! A Role playing game.");

            var arr = new[]
       {
                @"  __---~~~~--__                      __--~~~~---__",
                @" `\---~~~~~~~~\\                    //~~~~~~~~---/' ",
                @"   \/~~~~~~~~~\||                  ||/~~~~~~~~~\/ ",
                @"               `\\                //'",
                @"                 `\\            //'",
                @"                   ||          ||   ",
                @"         ______--~~~~~~~~~~~~~~~~~~--______",
                @"    ___ // _-~                        ~-_ \\ ___ ",
                @"   `\__)\/~                              ~\/(__/' ",
                @"    _--`-___                            ___-'--_   ",
                @"  /~     `\ ~~~~~~~~------------~~~~~~~~ /'     ~\ ",
                @" /|        `\         ________         /'        |\",
                @"| `\   ______`\_      \------/      _/'______   /' |",
                @"|   `\_~-_____\ ~-________________-~ /_____-~_/'   | ",
                @"`.     ~-__________________________________-~     .'",
                @" `.      [_______/------|~~|------\_______]      .'",
                @"  `\--___((____)(________\/________)(____))___--/' ",
                @"   |>>>>>>||                            ||<<<<<<|",
                @"                                                  ",
                };

            Console.WriteLine("\n\n");
            foreach (string line in arr)
                Console.WriteLine(line);
            Console.ReadKey();
                
                //start the game
                myGame.Start();

        }
    }
}

