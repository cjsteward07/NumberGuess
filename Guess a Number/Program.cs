int GetUserGuess(int userGuess)
{
    while (userGuess <= 1 || userGuess >= 100)
    {
        bool isValidInput;
        Console.Clear();
        Console.WriteLine($"Your guess of {userGuess} is invalid. Please enter a number BETWEEN 1 and 100: ");
        do
        {
            isValidInput = int.TryParse(Console.ReadLine(), out userGuess);
            if (isValidInput == false)
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please enter a number between 1 and 100");
            }
        } while (isValidInput == false);
    } 
    return userGuess;
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
        Console.Clear();
        Console.WriteLine("Too low, guess again");
    }
    else if (userGuess > returnValue)
    {
        Console.Clear();
        Console.WriteLine("Too high, guess again");
    }
}

bool playAgain;
do
{
    Random random = new Random();
    int returnValue = random.Next(1, 101);
    int userGuess = 0;
    bool isValidInput;

    Console.WriteLine("I am thinking of a number between 1-100.  Can you guess what it is?");

    while (userGuess != returnValue)
    {
        do
        {
            isValidInput = int.TryParse(Console.ReadLine(), out userGuess);
            if (isValidInput == false)
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please enter a number between 1 and 100");
            }
        } while (isValidInput == false);

        userGuess = GetUserGuess(userGuess);
        VerifyUserGuess(returnValue, userGuess);
    }

    Console.WriteLine("Well done! The answer was " + returnValue);
    Console.WriteLine("Would you like to play again (y/n)?");
    string input = Console.ReadLine();
    playAgain = input.ToLower() == "y";
} while (playAgain == true);

