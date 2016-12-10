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

        Console.WriteLine("Your username is " + name);
        GameTimer();



        //Enter Password
        IncorrectLoop:
        Console.WriteLine("   \nPlease Enter a password. \nNOTE: Password must have a length of 4 or more.");
        password = Console.ReadLine();
        GameTimer();

        while (password.Length >= 4)
        {
            Console.WriteLine("Your password is " + password + ". ");
            break;
        }
        
        if (password.Length > 4)
        {

        }
        else if (password.Length < 4)
        {
            Console.WriteLine("Sorry, you must Enter a valid password with 4 or more letters.");
            goto IncorrectLoop; 
            /*
            password = Console.ReadLine();
            Console.WriteLine(password + " is much better.");
            */
        }


            GameTimer();

        //Now time for the user to pick their vehicle. Below will display the different choices. 


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
        GameTimer();
        Console.WriteLine("Now its time to race!!! \nPRESS ANY KEY TO CONTINUE . . . \n");
        Console.ReadKey();
        Console.WriteLine(" \nWhat will your opponent be . . . ");

        //Random number generator for my enemy etc.


        int EnemyNumber = numberGenerator.Next(0, 3);

        switch (EnemyNumber)
        {
            case 0:
                EnemyCarInfo(Lamborgini);
                EnemyCarName = "Lamborgini";
                break;
            case 1:
                EnemyCarInfo(TrophyTruck);
                EnemyCarName = "Trophy Truck";
                break;
            case 2:
                EnemyCarInfo(ToyotaRav4);
                EnemyCarName = "Toyota Rav4";
                break;
            case 3:
                EnemyCarInfo(KTM450);
                EnemyCarName = "KTM 450";
                break;
            default:
                System.Console.WriteLine("You are going up against no one..");
                break;
        }

        //now i want to make a race between the player and the opponentVehicle.
        Console.WriteLine("Now its almost time to race! Would you like to customize your " + vehicleChoice + " before you race? \nType yes or no. . .");
        string answer = Console.ReadLine().ToLower();

        if (answer == "yes")
        {
            Console.WriteLine("\n \nAlright! Lets get your " + vehicleChoice + " some better parts!");
            // Customization before race.

            System.Console.WriteLine("What parts would you like to purchase? \n \n_____AVAILABLE PARTS_____ \n   - Tires \n  - Engine \n  - Body");
            string parts = Console.ReadLine().ToLower();
            GameTimer();

            switch (parts)
            {
                case "tires":
                    carChoice();

                    break;
                case "engine":
                    carChoice();

                    break;
                case "body":
                    carChoice();
                    break;
                default:
                    System.Console.WriteLine(parts + " is an invalid option. You should have spelled correctly. . . Now its race time! \n");
                    break;
            }


        }
        else if (answer == "no")
        {
            Console.WriteLine(" \nVery well.. I guess you are ready to race. \n Good luck racing.");
        }
        else
        {
            System.Console.WriteLine("You entered an invalid option.. \nYou give me no choice but to make you race now!");
        }


        Console.WriteLine("Now its time to race! \nPRESS ANY KEY TO CONTINUE . . .");
        GameTimer();
        
        
        //this is where the race begins. it begins as the player pushes a key. 

        //below is a count down timer from 3 to 1 then says Go!!
        int i = 3;
        while (i > 0)
        {
            Console.WriteLine(i);
            GameTimer();
            i--;
        }
        Console.WriteLine("Go!!!");
        GameTimer();

        //this is my random first set of sayings. These will display randomly giving the race a different experience every time 
        int raceStart = numberGenerator.Next(0, 3);

        switch (raceStart)
        {
            case 0:
                Console.WriteLine("Your " + vehicleChoice + " stalled! You quickly start it and accelerate behind the " + EnemyCarName + ".");
                GameTimer();
                break;
            case 1:
                Console.WriteLine("You accelerate in front of the " + EnemyCarName + ". ");
                GameTimer();
                break;
            case 2:
                Console.WriteLine("The " + EnemyCarName + " accelerates ahead of you.");
                GameTimer();
                break;
            default:
                System.Console.WriteLine("You both accelerate and are neck and neck. ");
                break;
        }
        // again another set of random 
        int raceMid = numberGenerator.Next(0, 3);
        switch (raceMid)
        {
            case 0:
                Console.WriteLine("You push your " + vehicleChoice + " to the limit.");
                GameTimer();
                break;
            case 1:
                Console.WriteLine("You do all you can to win");
                GameTimer();
                break;
            case 2:
                Console.WriteLine("You focus more intensly as you think about the grand prize.");
                GameTimer();
                break;
            default:
                System.Console.WriteLine("You are no just feet behind the opponent " + EnemyCarName + ". ");
                break;
        }




        //end of game ___________________
    }

    // race
    public string EnemyCarName;

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


    //Enemy vehicles
    EnemySportsCar Lamborgini = new EnemySportsCar();
    //trophy truck
    EnemyTrophyTruck TrophyTruck = new EnemyTrophyTruck();
    //rally car
    EnemyRallyCar ToyotaRav4 = new EnemyRallyCar();
    //dirt bike
    EnemyDirtBike KTM450 = new EnemyDirtBike();



    // Random Number generator
    Random numberGenerator = new Random();

    //Game Timer
    public static void GameTimer()
    {

        System.Threading.Thread.Sleep(1500);

    }




    // here is my function displaying my vehicle parts. 
    public void carChoice()
    {
        Console.WriteLine(" The new part you purchased will definitely help you in your race!");
        Console.WriteLine(" ");

    }


    // here is my function for displaying the vehicle statistics
    public void CarInfo(Car obj)
    {
        Console.WriteLine(" \nYou have chosen a " + obj.Type + "! Your " + obj.Type + " is a " + obj.CarName + " \n ---Top speed is: " + obj.TopSpeed + " \n ---Acceleration is: " + obj.Acceleration + " \n ---Handling is: " + obj.Handling + "% ");
    }
    //information for enemy vehicle
    public void EnemyCarInfo(Car obj)
    {
        Console.WriteLine(" \nYou are going up against a " + obj.Type + "! Your opponents vehicle is a " + obj.CarName + " \n ---Top speed is: " + obj.TopSpeed + " \n ---Acceleration is: " + obj.Acceleration + " \n ---Handling is: " + obj.Handling + "% ");
    }


}




