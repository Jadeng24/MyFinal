using System;
/*
I have decided i want to make a game that has to do with Cars.
First I need to do the basics like ask for UserName, Password, Age, and then 
I want to have a choice of vehicle such as: Truck, Rally Car, Sports car (ferarri)
, Dirt Bike. Once they choose their vehicle, (Switch Statement) It will 
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
//Game Class
public class Game {   
    public Game () {
        
    }
    //below is my game from beginning to end.
    public void Start () {
        Console.WriteLine("This game is all about Customizing your car and racing against other players! ");
        Console.WriteLine("Please type in your username.");
        name = Console.ReadLine();
        Console.WriteLine("Your username is " + name);
        
    
    


    
    }
    



//here are my attributes to my game.__________________________________________________

//Player name
public string name; 
}