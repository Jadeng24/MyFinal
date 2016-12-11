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
    public void  Start()
    {


        Console.WriteLine(" \nThis game is all about customizing your car and racing against other players! ");
        GameTimer();
        //enter name
        Console.WriteLine("   \nPlease type in your username.");
        name = Console.ReadLine();

        Console.WriteLine("Your username is " + name);
        GameTimer();



    //Enter Password
    IncorrectLoop:
        Console.WriteLine("   \nPlease enter a password. \nNOTE: Password must have a length of 4 or more.");
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

    //this is where the game starts over again when the player plays through the entire game and chooses to play again.
    Start:
        if (GameCounter > 1)
        {
            Console.WriteLine(" \nWelcome back to the Road Race " + name + "! ");
            WalletAmount = WalletAmount + 2500;
            
            GameLevel();
            System.Console.WriteLine("You earned a level up bonus of $" + 2500 + "! (press enter");
            Console.ReadKey();
            
            WalletReturn(); //returns the amount in wallet
            Console.ReadKey();
        }

        

        //Now time for the user to pick their vehicle. Below will display the different choices. 


        Console.WriteLine("     \n \n \nNow you choose your vehicle. \nIn Road Race, there is a wide variety of vehicles to choose from. \n     PRESS ANY KEY TO CONTINUE . . .");
        Console.ReadKey();
        if (GameCounter <= 2)
        {
            Console.WriteLine("  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - \nEach vehicle has different attributes of\n    TOP SPEED\n    ACCELERATION and\n    HANDLING. ");

        }
        switch(GameCounter) {
            case 2:
                Console.WriteLine("Congratulations! You have now unlocked the Rally Car! \n");
                break;
            case 3:
                Console.WriteLine("\nCongrats! You have now unlocked the Sports Car!! You have unlocked all the vehicles in the game!");
                break;
            default:
                break;
        }
    VehicleChoiceLoop: //Loop just in case user enters invalid option
        Console.WriteLine("Choose Between:");

        foreach (string value in vehicles)
        {

            Console.WriteLine("   * " + value);
        }
        vehicleChoice = Console.ReadLine().ToLower();

        switch (vehicleChoice)
        {
            case "sports car":
                if (GameCounter < 3)
                {
                    Console.WriteLine(" \nYou have not yet unlocked the " + vehicleChoice + ". You must be at level 3 to unlock the Sports Car. \nPlease try again.");
                    GameTimer();
                    GameTimer();
                    goto VehicleChoiceLoop;
                }

                else
                {
                    CarInfo(Ferrari);
                    VehicleTopSpeed = 180;
                }
                break;
            case "rally car":
                if (GameCounter < 2)
                {
                    Console.WriteLine(" \nYou have not yet unlocked the " + vehicleChoice + ". You must be at level 2 to unlock the Rally Car. \nPlease try again.");
                    GameTimer();
                    GameTimer();
                    goto VehicleChoiceLoop;
                }

                else
                {
                    CarInfo(SubaruImpressa);
                    VehicleTopSpeed = 120;
                }

                break;
            case "trophy truck":
                CarInfo(BajaTruck);
                VehicleTopSpeed = 100;
                break;

            case "dirt bike":
                CarInfo(Yamaha450f);
                VehicleTopSpeed = 80;
                break;
            default:
                System.Console.WriteLine("You have not entered a valid option. Please try again.");
                goto VehicleChoiceLoop;
                break;
        }
        int CashPrize = numberGenerator.Next(1000, 8000);
        GameTimer();
        Console.WriteLine("Now its time to race!!! \n$$$$$$$ Cash prize: $" + CashPrize + "$$$$$$$\nPRESS ANY KEY TO CONTINUE . . . \n");
        Console.ReadKey();
        Console.WriteLine(" \nWhat will your opponent be . . . ");
        GameTimer();
        Console.WriteLine("Choosing opponent. . .\n \n ");
        GameTimer();

        //Random number generator for my enemy etc.


        int EnemyNumber = numberGenerator.Next(0, 3);

        switch (EnemyNumber)
        {
            case 0:
                EnemyCarInfo(Lamborgini);
                EnemyCarName = "Lamborgini";
                EnemyTopSpeed = 200;
                break;
            case 1:
                EnemyCarInfo(TrophyTruck);
                EnemyCarName = "Monster Energy Truck";
                EnemyTopSpeed = 110;
                break;
            case 2:
                EnemyCarInfo(ToyotaRav4);
                EnemyCarName = "Toyota Rav4";
                EnemyTopSpeed = 130;
                break;
            case 3:
                EnemyCarInfo(KTM450);
                EnemyCarName = "KTM 450";
                EnemyTopSpeed = 85;
                break;
            default:
                System.Console.WriteLine("You are going up against no one..");
                break;
        }

        //now i want to make a race between the player and the opponentVehicle.
        Console.WriteLine(name + ", before you race, would you like to customize your " + vehicleChoice + " before you race? \nType yes or no. . .");
        string answer = Console.ReadLine().ToLower();

        if (answer == "yes")
        {

            Console.WriteLine("\n \nWELCOME TO THE BODY SHOP! \n Lets get your " + vehicleChoice + " some better parts!");

        // BODY SHOP _________________
        // This is where the player can customize their vehicle. they may purchase what they have money for. else they will have to try again. 
        CustomizeTryAgain:
            System.Console.WriteLine("What parts would you like to purchase? You have $" + WalletAmount + " in your Wallet. \n \n_____AVAILABLE PARTS_____ \n  - Tires $1500 \n  - Engine $8000 \n  - Transmission $5000 \n  - Body $2000");
            string parts = Console.ReadLine().ToLower();
            GameTimer();

            switch (parts)
            {
                case "tires":
                    if (WalletAmount < 1500)
                    {
                        Console.WriteLine("You do not have enough money to purchase tires for your " + vehicleChoice + ". Please try again.");
                        goto CustomizeTryAgain;
                    }
                    Console.WriteLine("These new tires will be good for your " + vehicleChoice + "'s acceleration and handling!");
                    VehicleTopSpeed = VehicleTopSpeed + 15;
                    WalletAmount = WalletAmount - 1500;
                    Console.WriteLine("Your new top speed is " + VehicleTopSpeed + "MPH. ");
                    break;
                case "engine":
                    if (WalletAmount < 8000)
                    {
                        Console.WriteLine("You do not have enough money to purchase an engine for your " + vehicleChoice + ". Please try again.");
                        goto CustomizeTryAgain;
                    }
                    Console.WriteLine("This new engine will be great for your " + vehicleChoice + "'s top speed and acceleration!");
                    VehicleTopSpeed = VehicleTopSpeed + 35;
                    WalletAmount = WalletAmount - 8000;
                    Console.WriteLine("Your new top speed is " + VehicleTopSpeed + "MPH. ");
                    break;

                case "transmission":
                    if (WalletAmount < 5000)
                    {
                        Console.WriteLine("You do not have enough money to purchase a transmission for your " + vehicleChoice + ". Please try again.");
                        goto CustomizeTryAgain;
                    }
                    Console.WriteLine("This new transmission will be great for your " + vehicleChoice + "'s acceleration!");
                    VehicleTopSpeed = VehicleTopSpeed + 25;
                    WalletAmount = WalletAmount - 5000;
                    Console.WriteLine("Your new top speed is " + VehicleTopSpeed + "MPH. ");
                    break;

                case "body":
                    if (WalletAmount < 2000)
                    {
                        Console.WriteLine("You do not have enough money to purchase body parts for your " + vehicleChoice + ". Please try again.");
                        goto CustomizeTryAgain;
                    }
                    Console.WriteLine("These new body parts will be great for your " + vehicleChoice + "'s aerodynamics and top speed!");
                    VehicleTopSpeed = VehicleTopSpeed + 15;
                    WalletAmount = WalletAmount - 2000;
                    Console.WriteLine("Your new top speed is " + VehicleTopSpeed + "MPH. ");
                    break;

                default:
                    Console.WriteLine(parts + " is an invalid option. Please try again \n");
                    goto CustomizeTryAgain;
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
        Console.ReadKey();
        GameTimer();






        //this is where the race begins. it begins as the player pushes a key. 

        //below is a count down timer from 3 to 1 then says Go!!
        int i = 3;
        while (i > 0)
        {
            Console.WriteLine(" \n" + i);
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
                Console.WriteLine("\nYour " + vehicleChoice + " stalled! You quickly start it and accelerate behind the opponent " + EnemyCarName + ".");
                GameTimer();
                GameTimer();
                break;
            case 1:
                Console.WriteLine("\nYou accelerate in front of the opponent " + EnemyCarName + ". ");
                GameTimer();
                GameTimer();
                break;
            case 2:
                Console.WriteLine("\nThe " + EnemyCarName + " accelerates ahead of you.");
                GameTimer();
                GameTimer();
                break;
            default:
                System.Console.WriteLine("\nYou both accelerate and are neck and neck. ");
                GameTimer();
                GameTimer();
                break;
        }
        // again another set of random 
        int raceMid = numberGenerator.Next(0, 5);
        switch (raceMid)
        {
            case 0:
                Console.WriteLine("\nYou push your " + vehicleChoice + " to the limit and are now ten feet ahead of your opponent. (press enter)");
                Console.ReadKey();
                break;
            case 1:
                Console.WriteLine("\nYou focus on your shifting and find yourself fifty feet in front of the " + EnemyCarName + ". (press enter)");
                Console.ReadKey();
                break;
            case 2:
                Console.WriteLine("\nYou focus more intensly as you think about the grand prize. (press enter)");
                Console.ReadKey();
                break;
            default:
                System.Console.WriteLine("\nYou are now just feet behind the opponent " + EnemyCarName + ". (press enter)");
                Console.ReadKey();
                break;
        }

        // last set of random race scenarios
        int raceEnd = numberGenerator.Next(0, 3);
        switch (raceEnd)
        {
            case 0:
                Console.WriteLine("\nIn a final attempt to win, you use your Nitros NOS cartridge hoping to beat your opponent's " + EnemyCarName + ". (press enter)");
                Console.ReadKey();
                NOS = true;
                break;
            case 1:
                Console.WriteLine("\nNearing the end of the race, you take a short cut hoping to ensure you win. (press enter)");
                Console.ReadKey();
                NOS = false;
                break;
            case 2:
                Console.WriteLine("\nWith only 200 yards left, you put the pedal down and give your " + vehicleChoice + "'s engine everything its got!. (press enter)");
                Console.ReadKey();
                NOS = false;
                break;
            default:
                System.Console.WriteLine("\nSeeing the finish line ahead, you decide there is no choice but to disable your " + vehicleChoice + "'s engine computer \nchip in hope for a higher top speed. (press enter)");
                Console.ReadKey();
                NOS = false;
                break;
        }

        if (VehicleTopSpeed > EnemyTopSpeed)
        {
            Console.WriteLine(" \nAfter a long and hard race, (press enter)");
            Console.ReadKey();
            Console.WriteLine(" your " + vehicleChoice + ", with is amazing top speed of " + VehicleTopSpeed + "MPH (press enter)");
            Console.ReadKey();
            Console.WriteLine(" manages to pull ahead of the " + EnemyCarName + " and you win the race!!! (press enter)");
            Console.ReadKey();
            Console.WriteLine(" \nCongratulations, you won $" + CashPrize + "! (press enter) ");
            WalletAmount = WalletAmount + CashPrize; 
            WalletReturn(); //returns the amount in wallet
            System.Console.WriteLine(" \n \n \n     T H E   E N D ! ! ! ");
            GameTimer();
            // this else if will give those vehicles with less top speed a chance to still win with a boost factor.
            // this gives the game a chance to win even when you have the slowest against the fastest vehicle.
        }
        else if (VehicleTopSpeed <= EnemyTopSpeed && NOS == true)
        {
            int BeatBySeconds = numberGenerator.Next(2, 10);
            Console.WriteLine("Even with your slow " + vehicleChoice + ", (press enter)");
            Console.ReadKey();
            Console.WriteLine("You boost forward with your Nitros NOS cartridge and fly past the opponent's " + EnemyCarName + " just before the finish line \nbeating him by " + BeatBySeconds + " seconds!! \nCONGRATULATIONS! You won the race! \nCash Prize: $" + CashPrize + "! (press enter) ");
            WalletAmount = WalletAmount + CashPrize;
            WalletReturn();
            Console.ReadKey();
            Console.WriteLine(" \n \n \n     T H E   E N D ! ! ! ");
        }

        else if (VehicleTopSpeed <= EnemyTopSpeed)
        {
            int BeatBySeconds = numberGenerator.Next(1, 8);
            Console.WriteLine("After a mentally and physically challenging race, (press enter)");
            Console.ReadKey();
            Console.WriteLine("your opponent's quick " + EnemyCarName + " gained momentum on the straight away and (press enter)");
            Console.ReadKey();
            Console.WriteLine(" beat you by " + BeatBySeconds + " seconds. (press enter)");
            Console.WriteLine("        YOU LOSE. \n \n \n     G A M E   O V E R ! ! ! ");
        }




        GameTimer();
    //play again command
    PlayAgainChoiceLoop:

        System.Console.WriteLine("Would you like to play again? \n Type: yes or no");
        playAgain = Console.ReadLine();
        if (playAgain == "yes")
        {
            GameCounter = GameCounter + 1;

            goto Start;
        }
        else if (playAgain == "no")
        {
            System.Console.WriteLine("\n\nThanks for playing Road Race! ");
        }
        else
        {
            System.Console.WriteLine("You need to slow down on your keyboard typing. \nYou have entered an invalid option. Please try again.");
            GameTimer();
            goto PlayAgainChoiceLoop;
        }

        //end of game ___________________
    }








    // this is how much money the player has to spend in the Body shop.
    public int WalletAmount = 6000;
    public void WalletReturn() {
        Console.WriteLine("Your wallet amount is now: $" + WalletAmount + ". (press enter)");
    }
    public int GameCounter = 1;
    public void GameLevel() {
        Console.WriteLine("You are now at Level " + GameCounter + ". (press enter)");
    }


    public bool NOS = false;


    public string playAgain;

    // Game information 

    //Player name & password   
    public string name;
    public string password;


    //vehicle strings
    string[] vehicles = { "Sports Car - Price $150,000", "Rally Car- Price: $100,000", "Trophy Truck - Price: $50,000", "Dirt Bike - Price: $25,000" };
    public string EnemyCarName;
    public int VehicleTopSpeed;



    // vehicle choice
    public string vehicleChoice = "sports car";

    // vehicles

    //sports car
    SportsCar Ferrari = new SportsCar();
    //trophy truck
    TrophyTruck BajaTruck = new TrophyTruck();
    //rally car
    RallyCar SubaruImpressa = new RallyCar();
    //dirt bike
    DirtBike Yamaha450f = new DirtBike();

    //Enemy vehicle information
    public int EnemyTopSpeed;

    //Enemy vehicles
    EnemySportsCar Lamborgini = new EnemySportsCar();
    //trophy truck
    EnemyTrophyTruck TrophyTruck = new EnemyTrophyTruck();
    //rally car
    EnemyRallyCar ToyotaRav4 = new EnemyRallyCar();
    //dirt bike
    EnemyDirtBike KTM450 = new EnemyDirtBike();



    //New parts for vehicles.
    Tire tirePart = new Tire();
    Engine enginePart = new Engine();
    Transmission transmissionPart = new Transmission();
    Body bodyPart = new Body();

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
        Console.WriteLine("Your new part you purchased will definitely help you in your race!");
        Console.WriteLine(" ");

    }


    // here is my function for displaying the vehicle statistics
    public void CarInfo(Car obj)
    {
        Console.WriteLine(" \nYou have chosen a " + obj.Type + "! Your " + obj.Type + " is a " + obj.CarName + " \n ---Top speed is: " + obj.TopSpeed + "MPH \n ---Acceleration is: " + obj.Acceleration + " \n ---Handling is: " + obj.Handling + "% ");
    }
    //information for enemy vehicle
    public void EnemyCarInfo(Car obj)
    {
        Console.WriteLine(" \nYou are going up against a " + obj.Type + "! Your opponents vehicle is a " + obj.CarName + " \n ---Top speed is: " + obj.TopSpeed + "MPH \n ---Acceleration is: " + obj.Acceleration + " \n ---Handling is: " + obj.Handling + "% ");
    }


}




