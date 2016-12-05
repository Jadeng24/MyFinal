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
public class Game
{

    //below is my game from beginning to end.
    public void Start()
    {


        Console.WriteLine(" \nThis game is all about Customizing your car and racing against other players! ");
        GameTimer();
        //enter name
        Console.WriteLine("   \nPlease type in your username.");
        name = Console.ReadLine();
        GameTimer();
        Console.WriteLine("Your username is_____" + name + "_____.");
        GameTimer();

        //enter Password
        Console.WriteLine("   \nPlease Enter a password", "Password must have a length of 4 or more.");
        password = Console.ReadLine();
        GameTimer();
        if (password.Length > 4)
        {
            Console.WriteLine("For now on, your password is_____" + password + "____.");
        }
        else if (password.Length <= 4)
        {
            Console.WriteLine("Sorry, you must Enter a valid password with 5 or more letters.");

            password = Console.ReadLine();
            Console.WriteLine(password + " is much better.");
            GameTimer();
        }
        Console.WriteLine("     \n \n \nNow its time to choose your vehicle. \n   In Road Race, there is a wide variety of vehicles to choose from. \n     PRESS ANY KEY TO CONTINUE . . .");
        Console.ReadKey();
        Console.WriteLine("  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - \nEach vehicle has different attributes of\n    TOP SPEED\n    ACCELERATION and\n    HANDLING. \n Now Choose Between Sports Car, Trophy Truck, Rally Car, or Dirt Bike.");
        vehicleChoice = Console.ReadLine().ToLower();

        switch (vehicleChoice)
        {
            case "sports car":
                CarInfo(Ferrari);
                break;
            case "trophy truck":
                CarInfo(BajaTruck);
                break;
            case "rally car":
                CarInfo(SubaruImpressa);
                break;
            case "dirt bike":
                CarInfo(Yamaha450f);
                break;
            default:
                break;
        }




    }
    // here is my function for displaying the vehicle statistics
    public void CarInfo(Car obj)
    {
        Console.WriteLine(" \nYou have chosen a " + obj.Type + "! Your sports car is a " + obj.CarName + " \n ---Top speed is: " + obj.TopSpeed + " \n ---Acceleration is: " + obj.Acceleration + " \n ---Handling is: " + obj.Handling + "% ");
    }



    //here are my attributes to my game.__________________________________________________

    //Player name & password
    public string name;
    public string password;

    // vehicle choice
    public string vehicleChoice = "sports car";

    // vehicles___

    //sports car
    SportsCar Ferrari = new SportsCar();
    //trophy truck
    TrophyTruck BajaTruck = new TrophyTruck();
    //rally car
    RallyCar SubaruImpressa = new RallyCar();
    //dirt bike
    DirtBike Yamaha450f = new DirtBike();
    
    //Game Timer
    public static void GameTimer()
    {

        System.Threading.Thread.Sleep(1500);

    }
}

