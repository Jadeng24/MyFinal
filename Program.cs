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
                @" _ _ _ _ _ _ _PRESS ANY KEY TO START_ _ _ _ _ _ _ _ _",
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
/* Here are the requirements to the final._______________________
Base Program using .Net or Unity using C#
* 5 int Variables 
* 5 String Variables
5 Object Variables 
3 Functions without Parameters
3 Functions with Parameters
2 Functions with a return
* If Statements
* Use of the Else clause
4 Switch Statements
2 Arrays
3 Lists, (1 object list)
2 While Loops
1 For Loops
2 Foreach Loops
*5 Classes
*20 Commits to a New GIT
*/