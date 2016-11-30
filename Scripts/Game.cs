using System;
/*
I have decided i want to make a game that has to do with Cars.
First I need to do the basics like ask for UserName, Password, Age, and then 
I want to have a choice of vehicle such as: Truck, Rally Car, Sports car (ferarri)
Bullet Bike, Dirt Bike. Once they choose their vehicle, (Switch Statement) It will 
tell you the definition and the different specifications for that vehicle such as:
Top Speed, Acceleration, Handling, Traction, Breaking.
The user will them be given a certain amount of money to start out the game. I will 
then give them an option to upgrade their vehicle with different parts such as: 
Engine (TOP SPEED), Transmission (ACCELERATION), Steering/alignment (Handling) 
Tires (TRACTION), NITRO NOS (boost)
each of these parts will be a certain cost. The user will choose to buy any of these items
giving them a better chance of winning. if they do buy something, their bank account will be
decreased according to the price of the item bought. 

*/

public class Game {

    public Game () {
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
                @"    ___ // _-~                        ~-_ \\ ",
                @"   `\__)\/~                              ~\/(__/' ",
                @"    _--`-___                            ___-'--_   ",
                @"  /~     `\ ~~~~~~~~------------~~~~~~~~ /'     ~\ ",
                @" /|        `\         ________         /'        |\",
                @"| `\   ______`\_      \------/      _/'______   /' |",
                @"|   `\_~-_____\ ~-________________-~ /_____-~_/'   | ",
                @"`.     ~-__________________________________-~     .'",
                @" `.      [_______/------|~~|------\_______]      .'",
                @"  `\--___((____)(________\/________)(____))___--/' ",
                @"   |>>>>>>||                            ||<<<<<<|"
                };

        Console.WriteLine("\n\n");
        foreach (string line in arr) 
            Console.WriteLine(line);
        Console.ReadKey();
        Console.WriteLine("This game is all about Customizing your car and racing against other players! ");

         

    }

}
