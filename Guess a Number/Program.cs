


//void GetUserGuess(int returnValue, int userGuess)
//{
//    if (userGuess > 1 && userGuess < 100)
//    {
//        Console.WriteLine("Valid Input");

//        VerifyUserGuess(returnValue, userGuess);
//    }
//    else
//    {
//        Console.WriteLine("Invalid Input");
        
//    }
//}


//void VerifyUserGuess(int returnValue, int userGuess)
//{
//    if (userGuess == returnValue)
//    {
//        Console.WriteLine("Congrats, you guessed the correct number");
//    }
//    else
//    {
//        ProvideAHint(returnValue, userGuess);
//    }
//}

//void ProvideAHint(int returnValue, int userGuess)
//{
//    if (userGuess < returnValue)
//    {
//        Console.WriteLine("Too low, guess again");
//    }
//    else if (userGuess > returnValue)
//    {
//        Console.WriteLine("Too high, guess again");
//    }
//}






//bool playAgain;
//do
//{
//    Random random = new Random();
//    int returnValue = random.Next(1, 101);
//    int userGuess = 0;

//    Console.WriteLine("I am thinking of a number between 1-100.  Can you guess what it is?");

//    while (userGuess != returnValue)
//    {
//        userGuess = Convert.ToInt32(Console.ReadLine());
//        GetUserGuess(returnValue, userGuess);

//        //    if (userGuess < returnValue)
//        //    {
//        //        Console.WriteLine("No, the number I am thinking of is higher than " + userGuess +
//        //                          ". Can you guess what it is?");
//        //    }
//        //    else if (userGuess > returnValue)
//        //    {
//        //        Console.WriteLine("No, the number I am thinking of is lower than " + userGuess +
//        //                          ". Can you guess what it is?");
//        //    }
//    }

//    Console.WriteLine("Well done! The answer was " + returnValue);
//    Console.WriteLine("Would you like to play again (y/n)?");
//    string input = Console.ReadLine();
//    playAgain = input.ToLower() == "y";
//} while (playAgain == true);









int GetUserGuess(int userGuess)
{
    if (userGuess > 1 && userGuess < 100)
    {
        //Console.WriteLine("Valid Input");

        return userGuess;
        //VerifyUserGuess(returnValue, userGuess);
    }
    else
    {
        return 0;
    }
    //else
    //{
    //    Console.WriteLine("Invalid Input");
        

    //}
}


void VerifyUserGuess(int returnValue, int userGuess)
{
    if (userGuess == returnValue)
    {
        Console.WriteLine("Congrats, you guessed the correct number");
    }
    else
    {
        ProvideAHint(returnValue, userGuess);
    }
}

void ProvideAHint(int returnValue, int userGuess)
{
    if (userGuess < returnValue)
    {
        Console.WriteLine("Too low, guess again");
    }
    else if (userGuess > returnValue)
    {
        Console.WriteLine("Too high, guess again");
    }
}






bool playAgain;
do
{
    Random random = new Random();
    int returnValue = random.Next(1, 101);
    int userGuess = 0;

    Console.WriteLine("I am thinking of a number between 1-100.  Can you guess what it is?");

    while (userGuess != returnValue)
    {
        userGuess = Convert.ToInt32(Console.ReadLine());
        userGuess = GetUserGuess(userGuess);
        VerifyUserGuess(returnValue, userGuess);

        //    if (userGuess < returnValue)
        //    {
        //        Console.WriteLine("No, the number I am thinking of is higher than " + userGuess +
        //                          ". Can you guess what it is?");
        //    }
        //    else if (userGuess > returnValue)
        //    {
        //        Console.WriteLine("No, the number I am thinking of is lower than " + userGuess +
        //                          ". Can you guess what it is?");
        //    }
    }

    Console.WriteLine("Well done! The answer was " + returnValue);
    Console.WriteLine("Would you like to play again (y/n)?");
    string input = Console.ReadLine();
    playAgain = input.ToLower() == "y";
} while (playAgain == true);